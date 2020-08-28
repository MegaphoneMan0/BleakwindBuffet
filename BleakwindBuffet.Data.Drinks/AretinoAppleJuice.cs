using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: AretinoAppleJuice.cs
     * Purpose: To track Aretino Apple Juice
     */
    class AretinoAppleJuice
    {

        //standard
        private double smallPrice = 0.62;
        private double mediumPrice = 0.87;
        private double largePrice = 1.01;

        private uint smallCalories = 44;
        private uint mediumCalories = 88;
        private uint largeCalories = 132;

        private List<string> specialInstructions;




        //unique

        private bool ice = false;
        private Size size = Size.Small;


        public bool getIce()
        {
            return ice;
        }

        public void setIce(bool b)
        {
            ice = b;
            if (ice == true)
            {
                specialInstructions.Add("Add ice");
            }
        }


        public double getPrice()
        {
            if (size == Size.Small)
            {
                return smallPrice;
            }
            else if (size == Size.Medium)
            {
                return mediumPrice;
            }
            else
            {
                return largePrice;
            }
        }

        public uint getCalories()
        {
            if (size == Size.Small)
            {
                return smallCalories;
            }
            else if (size == Size.Medium)
            {
                return mediumCalories;
            }
            else
            {
                return largeCalories;
            }
        }

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }

        public override string ToString()
        {
            return (size.ToString() + " Aretino Apple Juice");
        }










    }
}
