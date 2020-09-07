/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
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
        [InlineData(Enums.Small, 0.93)]
        [InlineData(Enums.Medium, 1.28)]
        [InlineData(Enums.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 41)]
        [InlineData(Enums.Medium, 52)]
        [InlineData(Enums.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Enums size, uint calories)
        {
        }

        [Theory]
        [InlineData(Enums.Small, "Small Vokun Salad")]
        [InlineData(Enums.Medium, "Medium Vokun Salad")]
        [InlineData(Enums.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Enums size, string name)
        {
        }
    }
}