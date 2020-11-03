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
    public class WebsiteMenu
    {

        public static List<Entree> entrees;
        public static List<Drink> drinks;
        public static List<Side> sides;

        static WebsiteMenu()
        {

            entrees = Menu.Entrees();
            drinks = Menu.Drinks();
            sides = Menu.Sides();

        }


    }
}
