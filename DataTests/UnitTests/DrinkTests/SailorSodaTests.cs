/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
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

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
        }

        [Theory]
        [InlineData(Enums.Small, 1.42)]
        [InlineData(Enums.Medium, 1.74)]
        [InlineData(Enums.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 117)]
        [InlineData(Enums.Medium, 153)]
        [InlineData(Enums.Large, 205)]
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
        [InlineData(SodaFlavor.Cherry, Enums.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Enums.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Enums.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Enums.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Enums.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Enums.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Enums.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Enums.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Enums.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Enums.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Enums.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Enums.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Enums.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Enums.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Enums.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Enums.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Enums.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Enums.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Enums size, string name)
        {
        }
    }
}
