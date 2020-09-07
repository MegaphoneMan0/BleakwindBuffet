/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
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
        [InlineData(Enums.Small, 1.78)]
        [InlineData(Enums.Medium, 2.01)]
        [InlineData(Enums.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 151)]
        [InlineData(Enums.Medium, 236)]
        [InlineData(Enums.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Enums size, uint calories)
        {
        }

        [Theory]
        [InlineData(Enums.Small, "Small Fried Miraak")]
        [InlineData(Enums.Medium, "Medium Fried Miraak")]
        [InlineData(Enums.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Enums size, string name)
        {
        }
    }
}