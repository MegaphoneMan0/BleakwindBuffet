/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
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
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
        }

        [Theory]
        [InlineData(Enums.Small, 1.22)]
        [InlineData(Enums.Medium, 1.58)]
        [InlineData(Enums.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Enums size, double price)
        {
        }

        [Theory]
        [InlineData(Enums.Small, 105)]
        [InlineData(Enums.Medium, 142)]
        [InlineData(Enums.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Enums size, uint calories)
        {
        }

        [Theory]
        [InlineData(Enums.Small, "Small Mad Otar Grits")]
        [InlineData(Enums.Medium, "Medium Mad Otar Grits")]
        [InlineData(Enums.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Enums size, string name)
        {
        }
    }
}