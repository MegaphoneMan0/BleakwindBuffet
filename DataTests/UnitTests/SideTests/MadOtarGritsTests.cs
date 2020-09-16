/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interfaces;



namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.Equal(Size.Small, MOG.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.Equal(Size.Small, MOG.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.Empty(MOG.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits MOG = new MadOtarGrits()
            {

                Size = size

            };

            Assert.Equal(price, MOG.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits MOG = new MadOtarGrits()
            {

                Size = size

            };

            Assert.Equal(calories, MOG.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits MOG = new MadOtarGrits()
            {

                Size = size

            };

            Assert.Equal(MOG.ToString(), name);

        }







        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            MadOtarGrits MOG = new MadOtarGrits();

            Assert.IsAssignableFrom<IOrderItem>(MOG);
            Assert.IsAssignableFrom<Side>(MOG);

        }







    }
}