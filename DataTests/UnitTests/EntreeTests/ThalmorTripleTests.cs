/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;



namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Bun);

        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Ketchup);

        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Mustard);

        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Pickle);

        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Cheese);

        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Tomato);

        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Lettuce);

        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Mayo);

        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Bacon);

        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Egg);

        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Bun = true;
            Assert.True(TT.Bun);
            TT.Bun = false;
            Assert.False(TT.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple TT = new ThalmorTriple();

            TT.Ketchup = true;
            Assert.True(TT.Ketchup);
            TT.Ketchup = false;
            Assert.False(TT.Ketchup);

        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Mustard = true;
            Assert.True(TT.Mustard);
            TT.Mustard = false;
            Assert.False(TT.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple TT = new ThalmorTriple();

            TT.Pickle = true;
            Assert.True(TT.Pickle);
            TT.Pickle = false;
            Assert.False(TT.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Cheese = true;
            Assert.True(TT.Cheese);
            TT.Cheese = false;
            Assert.False(TT.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Tomato = true;
            Assert.True(TT.Tomato);
            TT.Tomato = false;
            Assert.False(TT.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Lettuce = true;
            Assert.True(TT.Lettuce);
            TT.Lettuce = false;
            Assert.False(TT.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Mayo = true;
            Assert.True(TT.Mayo);
            TT.Mayo = false;
            Assert.False(TT.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Bacon = true;
            Assert.True(TT.Bacon);
            TT.Bacon = false;
            Assert.False(TT.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Egg = true;
            Assert.True(TT.Egg);
            TT.Egg = false;
            Assert.False(TT.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.Equal(TT.Price, 8.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple TT = new ThalmorTriple();
            
            uint u = 943;

            Assert.Equal(TT.Calories, u);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple TT = new ThalmorTriple() {

                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg= includeEgg

            };

            if (!includeBun) Assert.Contains("Hold bun", TT.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", TT.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", TT.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", TT.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", TT.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", TT.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", TT.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", TT.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", TT.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", TT.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg) Assert.Empty(TT.SpecialInstructions);




        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", TT.ToString());

        }





        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            ThalmorTriple TT = new ThalmorTriple();

            Assert.IsAssignableFrom<IOrderItem>(TT);
            Assert.IsAssignableFrom<Entree>(TT);

        }





    }
}