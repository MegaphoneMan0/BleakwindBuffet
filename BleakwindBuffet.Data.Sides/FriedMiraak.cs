using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /*
     * Author: John Solomon
     * Class name: FriedMiraak.cs
     * Purpose: To track Fried Miraak
     */
    class FriedMiraak
    {



        //standard
        private double smallPrice = 1.78;
        private double mediumPrice = 2.01;
        private double largePrice = 2.88;

        private uint smallCalories = 151;
        private uint mediumCalories = 236;
        private uint largeCalories = 306;

        private Size size = Size.Small;
        private List<string> specialInstructions;


        public override string ToString()
        {
            return (size.ToString() + " Fried Miraak");
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
