using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    class Menu
    {
        /// <summary>
        /// a method which returns all possible entrees
        /// </summary>
        /// <returns></returns>
        static IEnumerable<IOrderItem> Entrees()
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
        static IEnumerable<IOrderItem> Sides()
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

            MadOtarGrits MOGsmall = new MadOtarGrits();
            MOGsmall.Size = Enums.Size.Small;
            MadOtarGrits MOGmedium = new MadOtarGrits();
            MOGmedium.Size = Enums.Size.Medium;
            MadOtarGrits MOGlarge = new MadOtarGrits();
            MOGlarge.Size = Enums.Size.Large;

            VokunSalad VSsmall = new VokunSalad();
            VSsmall.Size = Enums.Size.Small;
            VokunSalad VSmedium = new VokunSalad();
            VSmedium.Size = Enums.Size.Medium;
            VokunSalad VSlarge = new VokunSalad();
            VSlarge.Size = Enums.Size.Large;

            sides.Append(DWFsmall);
            sides.Append(DWFmedium);
            sides.Append(DWFlarge);

            sides.Append(FMsmall);
            sides.Append(FMmedium);
            sides.Append(FMlarge);

            sides.Append(MOGsmall);
            sides.Append(MOGmedium);
            sides.Append(MOGlarge);

            sides.Append(VSsmall);
            sides.Append(VSmedium);
            sides.Append(VSlarge);


            return sides;

        }

        /// <summary>
        /// A method which returns a list of all possible drinks
        /// </summary>
        /// <returns></returns>
        static IEnumerable<IOrderItem> Drinks()
        {
            IEnumerable<IOrderItem> drinks = Enumerable.Empty<IOrderItem>();

            AretinoAppleJuice AAJsmall = new AretinoAppleJuice();
            AAJsmall.Size = Enums.Size.Small;
            AretinoAppleJuice AAJmedium = new AretinoAppleJuice();
            AAJmedium.Size = Enums.Size.Medium;
            AretinoAppleJuice AAJlarge = new AretinoAppleJuice();
            AAJlarge.Size = Enums.Size.Large;

            CandlehearthCoffee CCsmall = new CandlehearthCoffee();
            CCsmall.Size = Enums.Size.Small;
            CandlehearthCoffee CCmedium = new CandlehearthCoffee();
            CCmedium.Size = Enums.Size.Medium;
            CandlehearthCoffee CClarge = new CandlehearthCoffee();
            CClarge.Size = Enums.Size.Large;

            MarkarthMilk MMsmall = new MarkarthMilk();
            MMsmall.Size = Enums.Size.Small;
            MarkarthMilk MMmedium = new MarkarthMilk();
            MMmedium.Size = Enums.Size.Medium;
            MarkarthMilk MMlarge = new MarkarthMilk();
            MMlarge.Size = Enums.Size.Large;

            WarriorWater WWsmall = new WarriorWater();
            WWsmall.Size = Enums.Size.Small;
            WarriorWater WWmedium = new WarriorWater();
            WWmedium.Size = Enums.Size.Medium;
            WarriorWater WWlarge = new WarriorWater();
            WWlarge.Size = Enums.Size.Large;


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
        static IEnumerable<IOrderItem> FullMenu()
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
