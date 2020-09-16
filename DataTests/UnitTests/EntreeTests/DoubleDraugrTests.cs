/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Bun);


        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.True(DD.Ketchup);


        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.True(DD.Mustard);


        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.True(DD.Pickle);


        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.True(DD.Cheese);


        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.True(DD.Tomato);


        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.True(DD.Lettuce);


        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.True(DD.Mayo);


        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {

            DoubleDraugr DD = new DoubleDraugr();

            DD.Bun = true;
            Assert.True(DD.Bun);
            DD.Bun = false;
            Assert.False(DD.Bun);

        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {

            DoubleDraugr DD = new DoubleDraugr();

            DD.Ketchup = true;
            Assert.True(DD.Ketchup);
            DD.Ketchup = false;
            Assert.False(DD.Ketchup);

        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr DD = new DoubleDraugr();

            DD.Mustard = true;
            Assert.True(DD.Mustard);
            DD.Mustard = false;
            Assert.False(DD.Mustard);

        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr DD = new DoubleDraugr();

            DD.Pickle = true;
            Assert.True(DD.Pickle);
            DD.Pickle = false;
            Assert.False(DD.Pickle);

        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr DD = new DoubleDraugr();

            DD.Cheese = true;
            Assert.True(DD.Cheese);
            DD.Cheese = false;
            Assert.False(DD.Cheese);

        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr DD = new DoubleDraugr();

            DD.Tomato = true;
            Assert.True(DD.Tomato);
            DD.Tomato = false;
            Assert.False(DD.Tomato);


        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr DD = new DoubleDraugr();

            DD.Lettuce = true;
            Assert.True(DD.Lettuce);
            DD.Lettuce = false;
            Assert.False(DD.Lettuce);

        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr DD = new DoubleDraugr();

            DD.Mayo = true;
            Assert.True(DD.Mayo);
            DD.Mayo = false;
            Assert.False(DD.Mayo);

        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.Equal(DD.Price, 7.32);


        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr DD = new DoubleDraugr();

            uint u = 843;

            Assert.Equal(DD.Calories, u);


        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr DD = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo

            };

            if (!includeBun) Assert.Contains("Hold bun", DD.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", DD.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", DD.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", DD.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", DD.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", DD.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", DD.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", DD.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo) Assert.Empty(DD.SpecialInstructions);


        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr DD = new DoubleDraugr();

            Assert.Equal("Double Draugr", DD.ToString());



        }





        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            DoubleDraugr DD = new DoubleDraugr();

            Assert.IsAssignableFrom<IOrderItem>(DD);
            Assert.IsAssignableFrom<Entree>(DD);

        }




    }
}