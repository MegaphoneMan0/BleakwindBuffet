/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;



namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher PP = new PhillyPoacher();

            Assert.True(PP.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher PP = new PhillyPoacher();

            Assert.True(PP.Onion);


        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher PP = new PhillyPoacher();

            Assert.True(PP.Roll);


        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher PP = new PhillyPoacher();

            PP.Sirloin = true;
            Assert.True(PP.Sirloin);
            PP.Sirloin = false;
            Assert.False(PP.Sirloin);

        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher PP = new PhillyPoacher();


            PP.Onion = true;
            Assert.True(PP.Onion);
            PP.Onion = false;
            Assert.False(PP.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher PP = new PhillyPoacher();

            PP.Roll = true;
            Assert.True(PP.Roll);
            PP.Roll = false;
            Assert.False(PP.Roll);

        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher PP = new PhillyPoacher();

            Assert.Equal(PP.Price, 7.23);


        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher PP = new PhillyPoacher();

            uint u = 784;
            Assert.Equal(PP.Calories, u);

        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher PP = new PhillyPoacher()
            {

                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            
            };

            if (!includeRoll) Assert.Contains("Hold roll", PP.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onion", PP.SpecialInstructions);
            if (!includeSirloin) Assert.Contains("Hold sirloin", PP.SpecialInstructions);

            if (includeRoll && includeOnion && includeSirloin) Assert.Empty(PP.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher PP = new PhillyPoacher();

            Assert.Equal("Philly Poacher", PP.ToString());

        }



        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            PhillyPoacher PP = new PhillyPoacher();

            Assert.IsAssignableFrom<IOrderItem>(PP);
            Assert.IsAssignableFrom<Entree>(PP);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(PP);

        }





    }
}