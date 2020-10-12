/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {

            WarriorWater WW = new WarriorWater();
            Assert.True(WW.Ice);

        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {

            WarriorWater WW = new WarriorWater();

            Assert.Equal(Size.Small, WW.Size);

        }

       

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater WW = new WarriorWater();


            WW.Ice = true;
            Assert.True(WW.Ice);
            WW.Ice = false;
            Assert.False(WW.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater WW = new WarriorWater();


            WW.Size = Size.Large;
            Assert.Equal(WW.Size, Size.Large);
            WW.Size = Size.Medium;
            Assert.Equal(WW.Size, Size.Medium);
            WW.Size = Size.Small;
            Assert.Equal(WW.Size, Size.Small);
        }

        

        [Fact]
        public void ShouldHaveCorrectPriceForSize()
        {

            WarriorWater WW = new WarriorWater();

            Assert.Equal(WW.Price, 0);


        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSize()
        {

            WarriorWater WW = new WarriorWater();
            uint u = 0;

            Assert.Equal(WW.Calories, u);


        }

        [Theory]
        [InlineData(true,true)]
        [InlineData(false,false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater WW = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };

            if (!includeIce) Assert.Contains("Hold Ice", WW.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add Lemon", WW.SpecialInstructions);

            if (includeIce && !includeLemon) Assert.Empty(WW.SpecialInstructions);

        }
        
        [Theory]
        [InlineData( Size.Small, "Small Warrior Water")]
        [InlineData( Size.Medium, "Medium Warrior Water")]
        [InlineData( Size.Large, "Large Warrior Water")]

        
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor( Size size, string name)
        {

            WarriorWater WW = new WarriorWater()
            {
                
                Size = size
            };

            Assert.Equal(WW.ToString(),name);


        }


        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            WarriorWater WW = new WarriorWater();

            Assert.IsAssignableFrom<IOrderItem>(WW);
            Assert.IsAssignableFrom<Drink>(WW);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(WW);




        }



    }
}
