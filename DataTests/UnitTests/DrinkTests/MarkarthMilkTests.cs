/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {

            MarkarthMilk MM = new MarkarthMilk();

            Assert.False(MM.Ice);


        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MarkarthMilk MM = new MarkarthMilk();

            Assert.Equal(Size.Small, MM.Size);

        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {

            MarkarthMilk MM = new MarkarthMilk();

            MM.Ice = true;
            Assert.True(MM.Ice);
            MM.Ice = false;
            Assert.False(MM.Ice);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {

            MarkarthMilk MM = new MarkarthMilk();

            MM.Size = Size.Large;
            Assert.Equal(MM.Size, Size.Large);
            MM.Size = Size.Medium;
            Assert.Equal(MM.Size, Size.Medium);
            MM.Size = Size.Small;
            Assert.Equal(MM.Size, Size.Small);

        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk MM = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(price, MM.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {

            MarkarthMilk MM = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(cal, MM.Calories);

        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {

            MarkarthMilk MM = new MarkarthMilk()
            {
                Ice = includeIce
            };

            if (includeIce) Assert.Contains("Add Ice", MM.SpecialInstructions);




            if (!includeIce) Assert.Empty(MM.SpecialInstructions);

        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {


            MarkarthMilk MM = new MarkarthMilk()
            {
                Size = size
            };

            Assert.Equal(MM.ToString(), name);


        }







        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            MarkarthMilk MM = new MarkarthMilk();

            Assert.IsAssignableFrom<IOrderItem>(MM);

        }




    }
}