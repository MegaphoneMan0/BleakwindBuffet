/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
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
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee CC = new CandlehearthCoffee();

            Assert.False(CC.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {

            CandlehearthCoffee CC = new CandlehearthCoffee();
            Assert.False(CC.Decaf);


        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee CC = new CandlehearthCoffee();
            Assert.False(CC.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {

            CandlehearthCoffee CC = new CandlehearthCoffee();

            Assert.Equal(Size.Small, CC.Size);


        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee CC = new CandlehearthCoffee();

            CC.Ice = true;
            Assert.True(CC.Ice);
            CC.Ice = false;
            Assert.False(CC.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {

            CandlehearthCoffee CC = new CandlehearthCoffee();

            CC.Decaf = true;
            Assert.True(CC.Decaf);
            CC.Decaf = false;
            Assert.False(CC.Decaf);

        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {

            CandlehearthCoffee CC = new CandlehearthCoffee();

            CC.RoomForCream= true;
            Assert.True(CC.RoomForCream);
            CC.RoomForCream = false;
            Assert.False(CC.RoomForCream);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {

            CandlehearthCoffee CC = new CandlehearthCoffee();

            CC.Size = Size.Large;
            Assert.Equal(CC.Size, Size.Large);
            CC.Size = Size.Medium;
            Assert.Equal(CC.Size, Size.Medium);
            CC.Size = Size.Small;
            Assert.Equal(CC.Size, Size.Small);



        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {


            CandlehearthCoffee CC = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(price, CC.Price);


        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee CC = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(cal, CC.Calories);


        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee CC = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream
            };

            if (includeIce) Assert.Contains("Add Ice", CC.SpecialInstructions);
            if (includeCream) Assert.Contains("Add Cream", CC.SpecialInstructions);

            if (!includeIce && !includeCream) Assert.Empty(CC.SpecialInstructions);

        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {

            CandlehearthCoffee CC = new CandlehearthCoffee()
            {
                Size = size,
                Decaf = decaf
            };



            Assert.Equal(CC.ToString(), name);




        }



        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            CandlehearthCoffee CC = new CandlehearthCoffee();

            Assert.IsAssignableFrom<IOrderItem>(CC);
            Assert.IsAssignableFrom<Drink>(CC);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(CC);

        }





    }
}
