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

            linqFilterByCategory();

            //filteredItems = Menu.FilterByCalories(filteredItems, caloriesMin, caloriesMax);
            linqFilterByCalories();

            //filteredItems = Menu.FilterByPrice(filteredItems, priceMin, priceMax);
            linqFilterByPrice();

        }

        /// <summary>
        /// This method searches for the search term in the title OR the discription
        /// </summary>
        private void linqSearch()
        {
            if (SearchTerms != null)
            {
                //first, we get two seperate lists, the list of items with the titles that have the search term and the list of items with descriptions that have the search term
                //the titles just go in the overall list, the descriptions go in their own thing
                
                filteredItems = filteredItems.Where(IOrderItem => IOrderItem.ToString() != null && IOrderItem.ToString().ToLower().Contains(SearchTerms.ToLower())).ToList();
                List<IOrderItem> descriptionSearch = new List<IOrderItem>();
                descriptionSearch = Menu.FullMenu().Where(IOrderItem => IOrderItem.Description != null && IOrderItem.Description.ToLower().Contains(SearchTerms.ToLower())).ToList();

                //then, we go through the descriptions and add items to filtered items accordingly

                

                foreach(IOrderItem orderItem in descriptionSearch)
                {
                    if (filteredItems.Count == 0)
                    {
                        filteredItems.Add(orderItem);
                    }

                    //default false
                    bool inThere = false;

                    foreach(IOrderItem firstOrderItem in filteredItems)
                    {
                        if (firstOrderItem.GetType() == orderItem.GetType())
                        {
                            inThere = true;
                        }
                    }
                    
                    if (!inThere)
                    {
                        filteredItems.Add(orderItem);
                    }
                }



            }
        }

        /// <summary>
        /// Filters by the category
        /// </summary>
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

        /// <summary>
        /// filters by calories
        /// </summary>
        private void linqFilterByCalories()
        {
            if (caloriesMin == null)
            {
                caloriesMin = 0;
            }

            if (caloriesMax == null)
            {
                //max for the form item
                caloriesMax = 1000;
            }

            filteredItems = filteredItems.Where(IOrderItem => IOrderItem.Calories != null && IOrderItem.Calories>caloriesMin && IOrderItem.Calories<caloriesMax).ToList();
        }

        /// <summary>
        /// filters by price
        /// </summary>
        private void linqFilterByPrice()
        {
            if (priceMin == null)
            {
                priceMin = 0;
            }

            if (priceMax == null)
            {
                priceMax = 11;
            }

            filteredItems = filteredItems.Where(IOrderItem => IOrderItem.Price != null && IOrderItem.Price > priceMin && IOrderItem.Price < priceMax).ToList();


        }






    }
}
