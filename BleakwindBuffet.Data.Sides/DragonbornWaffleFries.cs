using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /*
     * Author: John Solomon
     * Class name: DragonbornWaffleFries.cs
     * Purpose: To track Dragonborn Waffle Fries
     */
    public class DragonbornWaffleFries
    {
        //standard
        private double smallPrice = 0.42;
        private double mediumPrice = 0.76;
        private double largePrice = 0.96;

        private uint smallCalories = 77;
        private uint mediumCalories = 89;
        private uint largeCalories = 100;

        private Size size = Size.Small;
        private List<string> specialInstructions;


        public override string ToString()
        {
            return (size.ToString() + " Dragonborn Waffle Fries");
        }



        public Size getSize()
        {
            return size;
        }

        public void setSize(Size s)
        {
            size = s;
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
    }
}
