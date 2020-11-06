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


namespace BleakwindBuffetWebsite.Pages
{
    public class IndexModel : PageModel
    {

        public string SearchTerms { get; set; }

        public string[] orderItems { get; set; }

        public double caloriesMin { get; set; }

        public double caloriesMax { get; set; }

        public double priceMin { get; set; }

        public double priceMax { get; set; }


        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            orderItems = Request.Query["orderItems"];




        }
    }
}
