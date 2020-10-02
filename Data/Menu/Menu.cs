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

namespace BleakwindBuffet.Data.Menu
{
    public class Menu
    {
        /// <summary>
        /// a method which returns all possible entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DoubleDraugr DD = new DoubleDraugr();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            PhillyPoacher PP = new PhillyPoacher();
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            ThalmorTriple TT = new ThalmorTriple();
            ThugsTBone TTB = new ThugsTBone();

            IEnumerable<IOrderItem> entrees = Enumerable.Empty<IOrderItem>();

            entrees.Append(BB);
            entrees.Append(DD);
            entrees.Append(GOO);
            entrees.Append(PP);
            entrees.Append(SS);
            entrees.Append(TT);
            entrees.Append(TTB);

            return entrees;

        }
        /// <summary>
        /// a method which returns all possible sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            IEnumerable<IOrderItem> sides = Enumerable.Empty<IOrderItem>();

            DragonbornWaffleFries DWFsmall = new DragonbornWaffleFries();
            DWFsmall.Size = Enums.Size.Small;
            DragonbornWaffleFries DWFmedium = new DragonbornWaffleFries();
            DWFmedium.Size = Enums.Size.Medium;
            DragonbornWaffleFries DWFlarge = new DragonbornWaffleFries();
            DWFlarge.Size = Enums.Size.Large;


            FriedMiraak FMsmall = new FriedMiraak();
            FMsmall.Size = Enums.Size.Small;
            FriedMiraak FMmedium = new FriedMiraak();
            FMmedium.Size = Enums.Size.Medium;
            FriedMiraak FMlarge = new FriedMiraak();
            FMlarge.Size = Enums.Size.Large;


            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits MOG = new MadOtarGrits();
                MOG.Size = size;
                sides.Append(MOG);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits MOG = new MadOtarGrits();
                MOG.Size = size;
                sides.Append(MOG);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad VS = new VokunSalad();
                VS.Size = size;
                sides.Append(VS);
            }

            sides.Append(DWFsmall);
            sides.Append(DWFmedium);
            sides.Append(DWFlarge);

            sides.Append(FMsmall);
            sides.Append(FMmedium);
            sides.Append(FMlarge);

            


            return sides;

        }

        /// <summary>
        /// A method which returns a list of all possible drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            IEnumerable<IOrderItem> drinks = Enumerable.Empty<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice AAJ = new AretinoAppleJuice();

                AAJ.Size = size;
                drinks.Append(AAJ);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee CC = new CandlehearthCoffee();

                CC.Size = size;
                drinks.Append(CC);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk MM = new MarkarthMilk();

                MM.Size = size;
                drinks.Append(MM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater WW = new WarriorWater();

                WW.Size = size;
                drinks.Append(WW);
            }

            //Now for the Sailor Soda
            foreach (Size sizes in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda SS = new SailorSoda();

                    SS.Size = sizes;
                    SS.Flavor = sf;

                    drinks.Append(SS);

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
