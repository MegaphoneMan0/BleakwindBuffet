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
        public string category { get; set; }

        [BindProperty(SupportsGet = true)]
        public int caloriesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int caloriesMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public double priceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double priceMax { get; set; }


        public void OnGet()
        {
            


            List<IOrderItem> fullMenu = BleakwindBuffet.Data.Menu.Menu.FullMenu();
            foreach(IOrderItem item in BleakwindBuffet.Data.Menu.Menu.FilterByCategory(fullMenu, category))
            {
                filteredItems.Add(item);
            }
            foreach (IOrderItem item in BleakwindBuffet.Data.Menu.Menu.FilterByCalories(filteredItems, caloriesMin, caloriesMax))
            {
                filteredItems.Add(item);
            }
            foreach (IOrderItem item in BleakwindBuffet.Data.Menu.Menu.FilterByPrice(filteredItems, priceMin, priceMax))
            {
                filteredItems.Add(item);
            }


            


        }
    }
}
