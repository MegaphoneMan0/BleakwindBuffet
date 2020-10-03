/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        
        [Fact]
        public void shouldReturnAllEntrees()
        {
            IEnumerable<IOrderItem> testList = Enumerable.Empty<IOrderItem>();

            BriarheartBurger BB = new BriarheartBurger();
            DoubleDraugr DD = new DoubleDraugr();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            PhillyPoacher PP = new PhillyPoacher();
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            ThalmorTriple TT = new ThalmorTriple();
            ThugsTBone TTB = new ThugsTBone();
            testList.Append(BB);
            testList.Append(DD);
            testList.Append(GOO);
            testList.Append(PP);
            testList.Append(SS);
            testList.Append(TT);
            testList.Append(TTB);



            IEnumerable<IOrderItem> menuList = Menu.Entrees();

            Assert.Equal(menuList,testList);
            

        }


        [Fact]
        public void shouldReturnAllSides()
        {

            IEnumerable<IOrderItem> testList = Enumerable.Empty<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak FM = new FriedMiraak();
                FM.Size = size;
                testList.Append(FM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries DWF = new DragonbornWaffleFries();
                DWF.Size = size;
                testList.Append(DWF);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits MOG = new MadOtarGrits();
                MOG.Size = size;
                testList.Append(MOG);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad VS = new VokunSalad();
                VS.Size = size;
                testList.Append(VS);
            }



            IEnumerable<IOrderItem> menuList = Menu.Sides();
            Assert.Equal(menuList, testList);


        }


        [Fact]
        public void shouldReturnAllDrinks()
        {

            IEnumerable<IOrderItem> testList = Enumerable.Empty<IOrderItem>();



            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice AAJ = new AretinoAppleJuice();

                AAJ.Size = size;
                testList.Append(AAJ);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee CC = new CandlehearthCoffee();

                CC.Size = size;
                testList.Append(CC);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk MM = new MarkarthMilk();

                MM.Size = size;
                testList.Append(MM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater WW = new WarriorWater();

                WW.Size = size;
                testList.Append(WW);
            }

            //Now for the Sailor Soda
            foreach (Size sizes in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda SS = new SailorSoda();

                    SS.Size = sizes;
                    SS.Flavor = sf;

                    testList.Append(SS);

                }
            }

            IEnumerable<IOrderItem> menuList = Menu.Drinks();
            Assert.Equal(menuList, testList);





        }//checking drinks






        [Fact]
        public void shouldReturnFullMenu()
        {

            IEnumerable<IOrderItem> testList = Enumerable.Empty<IOrderItem>();

            BriarheartBurger BB = new BriarheartBurger();
            DoubleDraugr DD = new DoubleDraugr();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            PhillyPoacher PP = new PhillyPoacher();
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            ThalmorTriple TT = new ThalmorTriple();
            ThugsTBone TTB = new ThugsTBone();
            testList.Append(BB);
            testList.Append(DD);
            testList.Append(GOO);
            testList.Append(PP);
            testList.Append(SS);
            testList.Append(TT);
            testList.Append(TTB);


            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak FM = new FriedMiraak();
                FM.Size = size;
                testList.Append(FM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries DWF = new DragonbornWaffleFries();
                DWF.Size = size;
                testList.Append(DWF);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits MOG = new MadOtarGrits();
                MOG.Size = size;
                testList.Append(MOG);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad VS = new VokunSalad();
                VS.Size = size;
                testList.Append(VS);
            }




            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice AAJ = new AretinoAppleJuice();

                AAJ.Size = size;
                testList.Append(AAJ);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee CC = new CandlehearthCoffee();

                CC.Size = size;
                testList.Append(CC);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk MM = new MarkarthMilk();

                MM.Size = size;
                testList.Append(MM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater WW = new WarriorWater();

                WW.Size = size;
                testList.Append(WW);
            }

            //Now for the Sailor Soda
            foreach (Size sizes in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda SaSo = new SailorSoda();

                    SaSo.Size = sizes;
                    SaSo.Flavor = sf;

                    testList.Append(SaSo);

                }
            }




            IEnumerable<IOrderItem> menuList = Menu.FullMenu();
            Assert.Equal(menuList, testList);





        }//fullMenu






        }//class
}//namespace