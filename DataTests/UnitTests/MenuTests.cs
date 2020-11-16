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
using System.ComponentModel;



namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        
        [Fact]
        public void shouldReturnAllEntrees()
        {
            List<IOrderItem> testList = new List<IOrderItem>();

            bool containsBB = false;
            bool containsDD = false;
            bool containsGOO = false;
            bool containsPP = false;
            bool containsSS = false;
            bool containsTT = false;
            bool containsTTB = false;

            List<IOrderItem> menuList = Menu.Entrees();

            foreach(IOrderItem item in menuList)
            {

                if(item is BriarheartBurger)
                {
                    containsBB = true;
                }
                if (item is DoubleDraugr)
                {
                    containsDD = true;
                }
                if (item is GardenOrcOmelette)
                {
                    containsGOO = true;
                }
                if (item is PhillyPoacher)
                {
                    containsPP = true;
                }
                if (item is SmokehouseSkeleton)
                {
                    containsSS = true;
                }
                if (item is ThalmorTriple)
                {
                    containsTT = true;
                }
                if (item is ThugsTBone)
                {
                    containsTTB = true;
                }


            }//foreach
            Assert.True(containsBB);
            Assert.True(containsDD);
            Assert.True(containsGOO);
            Assert.True(containsPP);
            Assert.True(containsSS);
            Assert.True(containsTT);
            Assert.True(containsTTB);

        }


        [Fact]
        public void shouldReturnAllSides()
        {

            List<IOrderItem> testList = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak FM = new FriedMiraak();
                FM.Size = size;
                testList.Add(FM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries DWF = new DragonbornWaffleFries();
                DWF.Size = size;
                testList.Add(DWF);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits MOG = new MadOtarGrits();
                MOG.Size = size;
                testList.Add(MOG);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad VS = new VokunSalad();
                VS.Size = size;
                testList.Add(VS);
            }



            List<IOrderItem> menuList = Menu.Sides();

            int count = menuList.Count;

            for(int i = 0; i<count; i++)
            {
                Assert.IsType(menuList[i].GetType(), testList[i]);
            }


        }


        [Fact]
        public void shouldReturnAllDrinks()
        {

            List<IOrderItem> testList = new List<IOrderItem>();



            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice AAJ = new AretinoAppleJuice();

                AAJ.Size = size;
                testList.Add(AAJ);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee CC = new CandlehearthCoffee();

                CC.Size = size;
                testList.Add(CC);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk MM = new MarkarthMilk();

                MM.Size = size;
                testList.Add(MM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater WW = new WarriorWater();

                WW.Size = size;
                testList.Add(WW);
            }

            //Now for the Sailor Soda
            foreach (Size sizes in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda SS = new SailorSoda();

                    SS.Size = sizes;
                    SS.Flavor = sf;

                    testList.Add(SS);

                }
            }

            List<IOrderItem> menuList = Menu.Drinks();

            int count = menuList.Count;

            for (int i = 0; i < count; i++)
            {
                Assert.IsType(menuList[i].GetType(), testList[i]);
            }





        }//checking drinks



        [Fact]
        public void shouldReturnFullMenu()
        {

            List<IOrderItem> testList = new List<IOrderItem>();

            BriarheartBurger BB = new BriarheartBurger();
            DoubleDraugr DD = new DoubleDraugr();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            PhillyPoacher PP = new PhillyPoacher();
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            ThalmorTriple TT = new ThalmorTriple();
            ThugsTBone TTB = new ThugsTBone();
            testList.Add(BB);
            testList.Add(DD);
            testList.Add(GOO);
            testList.Add(PP);
            testList.Add(SS);
            testList.Add(TT);
            testList.Add(TTB);


            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak FM = new FriedMiraak();
                FM.Size = size;
                testList.Add(FM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries DWF = new DragonbornWaffleFries();
                DWF.Size = size;
                testList.Add(DWF);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits MOG = new MadOtarGrits();
                MOG.Size = size;
                testList.Add(MOG);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad VS = new VokunSalad();
                VS.Size = size;
                testList.Add(VS);
            }




            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice AAJ = new AretinoAppleJuice();

                AAJ.Size = size;
                testList.Add(AAJ);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee CC = new CandlehearthCoffee();

                CC.Size = size;
                testList.Add(CC);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk MM = new MarkarthMilk();

                MM.Size = size;
                testList.Add(MM);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater WW = new WarriorWater();

                WW.Size = size;
                testList.Add(WW);
            }

            //Now for the Sailor Soda
            foreach (Size sizes in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda SaSo = new SailorSoda();

                    SaSo.Size = sizes;
                    SaSo.Flavor = sf;

                    testList.Add(SaSo);

                }
            }




            List<IOrderItem> menuList = Menu.FullMenu();

            int count = menuList.Count;

            for (int i = 0; i < count; i++)
            {
                Assert.IsType(menuList[i].GetType(), testList[i]);
            };





        }//fullMenu




        //These were replaced by LINQ methods
        //degradated code
        /*

        [Theory]
        [InlineData(null)]
        [InlineData("DoubleDraugr")]
        
        public void searchShouldSearch(string searchTerm)
        {

            List<IOrderItem> fullMenu = Menu.FullMenu();

            IEnumerable<IOrderItem> filteredMenu = Menu.Search(fullMenu, searchTerm).ToList();

            if (String.IsNullOrEmpty(searchTerm))
            {
                Assert.Equal(fullMenu, filteredMenu);
            }
            else
            {
                IEnumerable<IOrderItem> doubleDraugr = new List<IOrderItem>();
                doubleDraugr.Append(new DoubleDraugr());

                

                foreach (IOrderItem item in filteredMenu)
                {
                    Assert.Contains(item, doubleDraugr);
                }
            }
            

        }

        
        [Theory]
        [InlineData(null)]
        [InlineData("Entree")]
        public void shouldFilterByCategory(string searchTerm)
        {

            List<IOrderItem> fullMenu = Menu.FullMenu();

            List<IOrderItem> filteredItems = Menu.FilterByCategory(fullMenu, searchTerm);

            List<IOrderItem> entreeItems = Menu.Entrees();


            if (String.IsNullOrEmpty(searchTerm))
            {
                Assert.Equal(fullMenu, filteredItems);
            }

            else { 

            int count = filteredItems.Count;

            for (int i = 0; i < count; i++)
            {
                Assert.IsType(filteredItems[i].GetType(), entreeItems[i]);
            }
            }
        }


        
        [Theory]
        [InlineData(700,900)]
        [InlineData(800,900)]
        public void shouldFilterByCalories(int min, int max)
        {
            List<IOrderItem> fullMenu = Menu.FullMenu();

            List<IOrderItem> filteredItems = Menu.FilterByCalories(fullMenu, min, max);

            
            //the ones for 700 to 900
            if(min == 700)
            {
                List<IOrderItem> sevenHundredItems = new List<IOrderItem>();
                //Briarhearth Burger
                sevenHundredItems.Add(new BriarheartBurger());
                //Double Draugr
                sevenHundredItems.Add(new DoubleDraugr());
                //Philly Poacher
                sevenHundredItems.Add(new PhillyPoacher());

                int count = filteredItems.Count;

                for (int i = 0; i < count; i++)
                {
                    Assert.IsType(filteredItems[i].GetType(), sevenHundredItems[i]);
                }

            }
            if (min == 800)
            {
                List<IOrderItem> sevenHundredItems = new List<IOrderItem>();
                
                //Double Draugr
                sevenHundredItems.Add(new DoubleDraugr());
                

                int count = filteredItems.Count;

                for (int i = 0; i < count; i++)
                {
                    Assert.IsType(filteredItems[i].GetType(), sevenHundredItems[i]);
                }

            }




        }


        [Theory]
        [InlineData(4.50,6.00)]
        [InlineData(4.50,5.00)]
        public void shouldFilterByPrice(double min, double max)
        {
            List<IOrderItem> fullMenu = Menu.FullMenu();

            List<IOrderItem> filteredItems = Menu.FilterByPrice(fullMenu, min, max);


            //4.5 to 6
            if (min == 6.00)
            {
                List<IOrderItem> sixItems = new List<IOrderItem>();
                //Smokehouse Skeleton
                sixItems.Add(new SmokehouseSkeleton());
                //Double Draugr
                sixItems.Add(new GardenOrcOmelette());
                

                int count = filteredItems.Count;

                for (int i = 0; i < count; i++)
                {
                    Assert.IsType(filteredItems[i].GetType(), sixItems[i]);
                }

            }


            //4.5 to 5
            if (min == 5.00)
            {
                List<IOrderItem> sixItems = new List<IOrderItem>();
                //Double Draugr
                sixItems.Add(new GardenOrcOmelette());


                int count = filteredItems.Count;

                for (int i = 0; i < count; i++)
                {
                    Assert.IsType(filteredItems[i].GetType(), sixItems[i]);
                }

            }




        }



        */



    }//class
}//namespace