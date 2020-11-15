using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Abstract;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Menu;

namespace Website
{
    /*
     * Author: John Solomon
     * Class name: WebsiteMenu.cs
     * Purpose: WebsiteMenu provides some structures for the website to use when displaying data. This include all available items of an abstract data class and the different types of abstract data classes from the data library
     */
    public class WebsiteMenu
    {

        public static List<IOrderItem> entrees;
        public static List<IOrderItem> drinks;
        public static List<IOrderItem> sides;

        static WebsiteMenu()
        {

            entrees = Menu.Entrees();
            drinks = Menu.Drinks();
            sides = Menu.Sides();

        }

        /// <summary>
        /// Gets the possible order Items
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
            "Entree",
            "Drink",
            "Side",
            };
        }



    }
}
