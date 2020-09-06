using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /*
     * Author: John Solomon
     * Class name: MadOtarGrits.cs
     * Purpose: To track Mad Otar Grits
     */
    public class MadOtarGrits
    {

        //special instructions
        private List<string> specialInstructions;

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }







        //standard
        private double smallPrice = 1.22;
        private double mediumPrice = 1.58;
        private double largePrice = 1.93;

        private uint smallCalories = 105;
        private uint mediumCalories = 142;
        private uint largeCalories = 179;

        private Size size = Size.Small;


        



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

        








        //to string
        public override string ToString()
        {
            return (size.ToString() + " Mad Otar Grits");
        }


    }
}
