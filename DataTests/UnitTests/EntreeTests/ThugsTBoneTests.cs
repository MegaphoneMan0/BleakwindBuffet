/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Equal(TTB.Price,6.44);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone TTB = new ThugsTBone();
            uint u = 982;
            Assert.Equal(TTB.Calories, u);

        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Empty(TTB.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", TTB.ToString());
        }
    }
}