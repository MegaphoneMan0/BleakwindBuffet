/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            Assert.False(AAJ.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            Assert.Equal(Size.Small, AAJ.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {

            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            AAJ.Ice = true;
            Assert.True(AAJ.Ice);
            AAJ.Ice = false;
            Assert.False(AAJ.Ice);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {

            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            AAJ.Size = Size.Large;
            Assert.Equal(AAJ.Size, Size.Large);
            AAJ.Size = Size.Medium;
            Assert.Equal(AAJ.Size, Size.Medium);
            AAJ.Size = Size.Small;
            Assert.Equal(AAJ.Size, Size.Small);

        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(price, AAJ.Price);

        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {

            AretinoAppleJuice AAJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(cal, AAJ.Calories);

        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {

            AretinoAppleJuice AAJ = new AretinoAppleJuice()
            {
                Ice = includeIce
            };

            if (includeIce) Assert.Contains("Add Ice",AAJ.SpecialInstructions);




            if (!includeIce) Assert.Empty(AAJ.SpecialInstructions);


        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {


            AretinoAppleJuice AAJ = new AretinoAppleJuice()
            {
                Size = size
            };

            Assert.Equal(AAJ.ToString(),name);



        }//test




        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            Assert.IsAssignableFrom<IOrderItem>(AAJ);
            Assert.IsAssignableFrom<Drink>(AAJ);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(AAJ);


        }





        [Fact]
        public void DidThePropertyChange()
        {

            AretinoAppleJuice AAJ = new AretinoAppleJuice();

        }















    }//class
}//namespace