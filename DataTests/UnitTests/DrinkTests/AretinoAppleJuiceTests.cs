/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
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
        public void ShouldBeAbleToSetSize()
        {
        }

        [Theory]
        [InlineData(Enums.Small, 0.62)]
        [InlineData(Enums.Medium, 0.87)]
        [InlineData(Enums.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 44)]
        [InlineData(Enums.Medium, 88)]
        [InlineData(Enums.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Enums size, uint cal)
        {
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
        }

        [Theory]
        [InlineData(Enums.Small, "Small Aretino Apple Juice")]
        [InlineData(Enums.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Enums.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Enums size, string name)
        {
        }
    }
}