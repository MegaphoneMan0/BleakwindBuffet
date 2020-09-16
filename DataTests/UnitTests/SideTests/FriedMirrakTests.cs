/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Abstract;


namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak FM = new FriedMiraak();
            Assert.Equal(Size.Small, FM.Size);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak FM = new FriedMiraak();
            Assert.Equal(Size.Small, FM.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak FM = new FriedMiraak();
            Assert.Empty(FM.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak FM = new FriedMiraak()
            {

                Size = size

            };

            Assert.Equal(price, FM.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak FM = new FriedMiraak()
            {

                Size = size

            };

            Assert.Equal(calories, FM.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak FM = new FriedMiraak()
            {

                Size = size

            };

            Assert.Equal(FM.ToString(), name);
        }




        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            FriedMiraak FM = new FriedMiraak();

            Assert.IsAssignableFrom<IOrderItem>(FM);
            Assert.IsAssignableFrom<Side>(FM);

        }






    }
}