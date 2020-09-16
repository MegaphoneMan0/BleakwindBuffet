/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;



namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            Assert.True(GOO.Broccoli);

        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            Assert.True(GOO.Mushrooms);


        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            Assert.True(GOO.Tomato);


        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            Assert.True(GOO.Cheddar);


        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            GOO.Broccoli = true;
            Assert.True(GOO.Broccoli);
            GOO.Broccoli = false;
            Assert.False(GOO.Broccoli);


        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            GOO.Mushrooms = true;
            Assert.True(GOO.Mushrooms);
            GOO.Mushrooms = false;
            Assert.False(GOO.Mushrooms);

        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            GOO.Tomato = true;
            Assert.True(GOO.Tomato);
            GOO.Tomato = false;
            Assert.False(GOO.Tomato);

        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            GOO.Cheddar = true;
            Assert.True(GOO.Cheddar);
            GOO.Cheddar = false;
            Assert.False(GOO.Cheddar);

        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            Assert.Equal(GOO.Price, 4.57);


        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();

            uint u = 404;

            Assert.Equal(GOO.Calories, u);

        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };


            if (!includeBroccoli) Assert.Contains("Hold broccoli", GOO.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", GOO.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", GOO.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", GOO.SpecialInstructions);

            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar) Assert.Empty(GOO.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();


            Assert.Equal("Garden Orc Omelette", GOO.ToString());


        }




        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            GardenOrcOmelette GOO = new GardenOrcOmelette();

            Assert.IsAssignableFrom<IOrderItem>(GOO);
            Assert.IsAssignableFrom<Entree>(GOO);

        }




    }
}