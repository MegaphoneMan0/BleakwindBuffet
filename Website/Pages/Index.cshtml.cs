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
            filteredItems = BleakwindBuffet.Data.Menu.Menu.FullMenu();

            if (SearchTerms != null)
            {
                filteredItems = filteredItems.Where()
            }
            

            filteredItems = BleakwindBuffet.Data.Menu.Menu.FilterByCategory(filteredItems, category);

            filteredItems = BleakwindBuffet.Data.Menu.Menu.FilterByCalories(filteredItems, caloriesMin, caloriesMax);

            filteredItems = BleakwindBuffet.Data.Menu.Menu.FilterByPrice(filteredItems, priceMin, priceMax);
            


            


        }
    }
}
