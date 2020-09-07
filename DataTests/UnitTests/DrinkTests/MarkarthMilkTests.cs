/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
        }

        [Theory]
        [InlineData(Enums.Small, 1.05)]
        [InlineData(Enums.Medium, 1.11)]
        [InlineData(Enums.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 56)]
        [InlineData(Enums.Medium, 72)]
        [InlineData(Enums.Large, 93)]
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
        [InlineData(Enums.Small, "Small Markarth Milk")]
        [InlineData(Enums.Medium, "Medium Markarth Milk")]
        [InlineData(Enums.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Enums size, string name)
        {
        }
    }
}