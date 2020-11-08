using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.Security.Cryptography;
using BleakwindBuffet.Data.Abstract;
using System.Net;

namespace BleakwindBuffet.Data.Menu
{
    public class Menu
    {








        /// <summary>
        /// a method which returns all possible entrees
        /// </summary>
        /// <returns></returns>
        public static List<IOrderItem> Entrees()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DoubleDraugr DD = new DoubleDraugr();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            PhillyPoacher PP = new PhillyPoacher();
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            ThalmorTriple TT = new ThalmorTriple();
            ThugsTBone TTB = new ThugsTBone();

            List<IOrderItem> entrees = new List<IOrderItem>();

            entrees.Add(BB);
            entrees.Add(DD);
            entrees.Add(GOO);
            entrees.Add(PP);
            entrees.Add(SS);
            entrees.Add(TT);
            entrees.Add(TTB);

            return entrees;

        }
        /// <summary>
        /// a method which returns all possible sides
        /// </summary>
        /// <returns></returns>
        public static List<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();


            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak FM = new FriedMiraak();
                FM.Size = size;
                sides.Add(FM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries DWF = new DragonbornWaffleFries();
                DWF.Size = size;
                sides.Add(DWF);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits MOG = new MadOtarGrits();
                MOG.Size = size;
                sides.Add(MOG);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad VS = new VokunSalad();
                VS.Size = size;
                sides.Add(VS);
            }

            


            return sides;

        }

        /// <summary>
        /// A method which returns a list of all possible drinks
        /// </summary>
        /// <returns></returns>
        public static List<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice AAJ = new AretinoAppleJuice();

                AAJ.Size = size;
                drinks.Add(AAJ);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee CC = new CandlehearthCoffee();

                CC.Size = size;
                drinks.Add(CC);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk MM = new MarkarthMilk();

                MM.Size = size;
                drinks.Add(MM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater WW = new WarriorWater();

                WW.Size = size;
                drinks.Add(WW);
            }

            //Now for the Sailor Soda
            foreach (Size sizes in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda SS = new SailorSoda();

                    SS.Size = sizes;
                    SS.Flavor = sf;

                    drinks.Add(SS);

                }
            }






            return drinks;

        }


        /// <summary>
        /// a method which returns all available items on the menu
        /// </summary>
        /// <returns></returns>
        public static List<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();



            //Entrees

            List<IOrderItem> entrees = Entrees();

            foreach(IOrderItem item in entrees)
            {
                fullMenu.Add(item);
            }

            //sides

            List<IOrderItem> sides = Sides();

            foreach (IOrderItem item in sides)
            {
                fullMenu.Add(item);
            }
            //drinks

            List<IOrderItem> drinks = Drinks();
            foreach (IOrderItem item in drinks)
            {
                fullMenu.Add(item);
            }



            



            return fullMenu;

        }//fullmenu method



        //I think all of these work, but probably not :P

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> originalItems, string searchTerm)
        {

            List<IOrderItem> filteredItems = new List<IOrderItem>();

            if(searchTerm == null)
            {
                return originalItems;
            }

            foreach(IOrderItem item in originalItems)
            {
                if (item.ToString().Contains(searchTerm))
                {
                    filteredItems.Add(item);
                }
            }


            return filteredItems;

        }

        public static List<IOrderItem> FilterByCategory(List<IOrderItem> originalItems, string category)
        {

            List<IOrderItem> filteredItems = new List<IOrderItem>();

            if (category == null)
            {
                return originalItems;
            }


            foreach(IOrderItem item in originalItems)
            {
                //no fuckin clue if this will work or not
                if(item.GetType().BaseType.ToString() == category)
                {
                    filteredItems.Add(item);
                }
            }


            return filteredItems;

        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> originalItems, int min, int max)
        {

            List<IOrderItem> filteredItems = new List<IOrderItem>();

            foreach(IOrderItem item in originalItems)
            {
                if (item.Calories > min)
                {
                    if(item.Calories < max)
                    {
                        filteredItems.Add(item);
                    }
                }
            }



            return filteredItems;


        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> originalItems, double min, double max)
        {
            List<IOrderItem> filteredItems = new List<IOrderItem>();

            foreach (IOrderItem item in originalItems)
            {
                if (item.Price > min)
                {
                    if (item.Price < max)
                    {
                        filteredItems.Add(item);
                    }
                }
            }



            return filteredItems;
        }



    }//menu class
}
