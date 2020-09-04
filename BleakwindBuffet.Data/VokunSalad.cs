using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /*
     * Author: John Solomon
     * Class name: VokunSalad.cs
     * Purpose: To track Vokun Salad
     */
    public class VokunSalad
    {


        //standard
        private double smallPrice = 0.98;
        private double mediumPrice = 1.28;
        private double largePrice = 1.82;

        private uint smallCalories = 41;
        private uint mediumCalories = 52;
        private uint largeCalories = 73;

        private Size size = Size.Small;
        private List<string> specialInstructions;


        public override string ToString()
        {
            return (size.ToString() + " Vokun Salad");
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
