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

        }






    }//class
}//namespace