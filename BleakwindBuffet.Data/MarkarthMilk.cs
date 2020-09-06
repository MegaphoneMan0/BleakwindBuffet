using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: MarkarthMilk
     * Purpose: To track Markarth Milk
     */
    public class MarkarthMilk
    {


        //special instructions
        private List<string> specialInstructions;

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }








        //properties




        //standard
        private double smallPrice = 1.05;
        private double mediumPrice = 1.11;
        private double largePrice = 1.22;

        private uint smallCalories = 56;
        private uint mediumCalories = 72;
        private uint largeCalories = 93;





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

        

        




        public Size getSize()
        {
            return size;
        }

        public void setSize(Size s)
        {
            size = s;
        }










        //to string
        public override string ToString()
        {
            return (size.ToString() + " Markarth Milk");
        }



    }
}
