using System;
using Xunit;
using BleakwindBuffet;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace XUnitTestBleakwindBuffet.Data
{
    public class UnitTest1
    {





        //AretinoAppleJuice tests

        //Checking Defaults

        [Fact]
        public void SizeShouldBeSmallByDefault()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            Assert.Equal(Size.Small, AAJ.Size);

        }


        [Fact]
        public void IceShouldBeFalseByDefault()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            Assert.False(AAJ.Ice);

        }


        //Checking if we can set

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

        
        [Fact]
        public void ShouldBeAbleToSetIce()
        {

            AretinoAppleJuice AAJ = new AretinoAppleJuice();

            AAJ.Ice = true;
            Assert.True(AAJ.Ice);
            AAJ.Ice = false;
            Assert.False(AAJ.Ice);

        }



        //Checking tht variables are returning the correct values

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
            Assert.Equal(price,AAJ.Price);

        }


        [Theory]
        [InlineData(Size.Small,44)]
        [InlineData(Size.Small,88)]
        [InlineData(Size.Small,132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(cal,AAJ.Calories);

        }
































    }//class
}//namespace
