/*
 * Author: Zachery Brunner
 * Editor: John Solomon
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();

            Assert.True(SS.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {

            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.True(SS.Egg);


        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.True(SS.HashBrowns);

        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.True(SS.Pancake);

        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();

            SS.SausageLink = true;
            Assert.True(SS.SausageLink);
            SS.SausageLink = false;
            Assert.False(SS.SausageLink);

        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.Egg = true;
            Assert.True(SS.Egg);
            SS.Egg = false;
            Assert.False(SS.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.HashBrowns = true;
            Assert.True(SS.HashBrowns);
            SS.HashBrowns = false;
            Assert.False(SS.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.Pancake = true;
            Assert.True(SS.Pancake);
            SS.Pancake = false;
            Assert.False(SS.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.Equal(SS.Price, 5.62);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            uint u = 602;
            Assert.Equal(SS.Calories, u);

        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton() { 
            
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            
            
            };

            if (!includeSausage) Assert.Contains("Hold SausageLink", SS.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold Egg", SS.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold HashBrowns", SS.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold Pancake", SS.SpecialInstructions);

            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(SS.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();

            Assert.Equal("Smokehouse Skeleton", SS.ToString());




        }
    }
}