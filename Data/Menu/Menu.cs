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
        public static List<Entree> Entrees()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DoubleDraugr DD = new DoubleDraugr();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            PhillyPoacher PP = new PhillyPoacher();
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            ThalmorTriple TT = new ThalmorTriple();
            ThugsTBone TTB = new ThugsTBone();

            List<Entree> entrees = new List<Entree>();

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
        public static List<Side> Sides()
        {
            List<Side> sides = new List<Side>();


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
        public static List<Drink> Drinks()
        {
            List<Drink> drinks = new List<Drink>();

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
        public static IEnumerable<IOrderItem> FullMenu()
        {
            IEnumerable<IOrderItem> fullMenu = Enumerable.Empty<IOrderItem>();



            //Entrees

            IEnumerable<IOrderItem> entrees = Entrees();


            //sides

            IEnumerable<IOrderItem> sides = Sides();


            //drinks

            IEnumerable<IOrderItem> drinks = Drinks();



            fullMenu =  fullMenu.Concat(entrees);
            fullMenu = fullMenu.Concat(sides);
            fullMenu = fullMenu.Concat(drinks);



            return fullMenu;

        }//fullmenu method





    }//menu class
}
