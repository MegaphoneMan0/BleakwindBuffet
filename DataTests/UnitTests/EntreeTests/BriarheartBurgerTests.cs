/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;



namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
         
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger BB = new BriarheartBurger();

            BB.Bun = true;
            Assert.True(BB.Bun);
            BB.Bun = false;
            Assert.False(BB.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger BB = new BriarheartBurger();


            BB.Ketchup = true;
            Assert.True(BB.Ketchup);
            BB.Ketchup = false;
            Assert.False(BB.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger BB = new BriarheartBurger();

            BB.Mustard = true;
            Assert.True(BB.Mustard);
            BB.Mustard = false;
            Assert.False(BB.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Pickle = true;
            Assert.True(BB.Pickle);
            BB.Pickle = false;
            Assert.False(BB.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Cheese = true;
            Assert.True(BB.Cheese);
            BB.Cheese = false;
            Assert.False(BB.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger BB = new BriarheartBurger();

            Assert.Equal(BB.Price,6.32);

        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger BB = new BriarheartBurger();

            uint u = 743;
            Assert.Equal(BB.Calories, u);

        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger BB = new BriarheartBurger()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese
            
            };

            if (!includeBun) Assert.Contains("Hold bun", BB.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", BB.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", BB.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", BB.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", BB.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) Assert.Empty(BB.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.Equal("Briarheart Burger",BB.ToString());
        }




        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            BriarheartBurger BB = new BriarheartBurger();

            Assert.IsAssignableFrom<IOrderItem>(BB);
            Assert.IsAssignableFrom<Entree>(BB);

            Assert.IsAssignableFrom<INotifyPropertyChanged>(BB);


        }




    }
}