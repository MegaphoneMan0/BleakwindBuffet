/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
        }

        [Theory]
        [InlineData(Enums.Small, 0.42)]
        [InlineData(Enums.Medium, 0.76)]
        [InlineData(Enums.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 77)]
        [InlineData(Enums.Medium, 89)]
        [InlineData(Enums.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Enums size, uint calories)
        {
        }

        [Theory]
        [InlineData(Enums.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Enums.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Enums.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Enums size, string name)
        {
        }
    }
}