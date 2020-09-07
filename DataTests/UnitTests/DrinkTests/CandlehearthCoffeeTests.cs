/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
        }

        [Theory]
        [InlineData(Enums.Small, 0.75)]
        [InlineData(Enums.Medium, 1.25)]
        [InlineData(Enums.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 7)]
        [InlineData(Enums.Medium, 10)]
        [InlineData(Enums.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Enums size, uint cal)
        {
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
        }

        [Theory]
        [InlineData(true, Enums.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Enums.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Enums.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Enums.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Enums.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Enums.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Enums size, string name)
        {
        }
    }
}
