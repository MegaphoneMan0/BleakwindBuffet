using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel.DataAnnotations;
using BleakwindBuffet.Data.Interfaces;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.HPack;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;


namespace BleakwindBuffetWebsite.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<IOrderItem> filteredItems { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] category { get; set; } = new string[0];

        [BindProperty(SupportsGet = true)]
        public int? caloriesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? caloriesMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? priceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? priceMax { get; set; }


        public void OnGet()
        {


            //filteredItems = BleakwindBuffet.Data.Menu.Menu.Search(BleakwindBuffet.Data.Menu.Menu.FullMenu(), SearchTerms);
            //with linq
            filteredItems = Menu.FullMenu();


            linqSearch();
            
            filteredItems = Menu.FilterByCategory(filteredItems, category);

            filteredItems = Menu.FilterByCalories(filteredItems, caloriesMin, caloriesMax);

            filteredItems = Menu.FilterByPrice(filteredItems, priceMin, priceMax);
            

        }


        private void linqSearch()
        {
            if (SearchTerms != null)
            {
                
                filteredItems = filteredItems.Where(IOrderItem => IOrderItem.ToString() != null && IOrderItem.ToString().ToLower().Contains(SearchTerms.ToLower())).ToList();
            }
        }

        private void linqFilterByCategory()
        {
            if (category != null)
            {
                foreach (string s in category)
                {
                    filteredItems = filteredItems.Where(IOrderItem => IOrderItem.GetType().BaseType.Name != null && IOrderItem.GetType().BaseType.Name.ToLower().Contains(s.ToLower())).ToList();
                }
            }
        }


    }
}
