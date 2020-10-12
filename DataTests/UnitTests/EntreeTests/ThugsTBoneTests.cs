/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;



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







        [Fact]
        public void ShouldBeAssignableToAbstractClass()
        {

            ThugsTBone TTB = new ThugsTBone();

            Assert.IsAssignableFrom<IOrderItem>(TTB);
            Assert.IsAssignableFrom<Entree>(TTB);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TTB);

        }









    }
}