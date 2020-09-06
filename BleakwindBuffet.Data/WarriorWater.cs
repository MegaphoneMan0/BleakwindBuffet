using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: WarriorWater.cs
     * Purpose: To track Warrior Water
     */
    public class WarriorWater
    {
        //special instructions
        private List<string> specialInstructions;

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }















        //properties

        //standard
        private double smallPrice =0;
        private double mediumPrice = 0;
        private double largePrice = 0;

        private uint smallCalories = 0;
        private uint mediumCalories = 0;
        private uint largeCalories = 0;





        //unique

        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;


        public bool getIce()
        {
            return ice;
        }

        public void setIce(bool b)
        {
            ice = b;
            if (ice == false)
            {
                specialInstructions.Add("Hold ice");
            }
        }


        public bool getLemon()
        {
            return lemon;
        }

        public void setLemon(bool b)
        {
            lemon = b;
            if (lemon == true)
            {
                specialInstructions.Add("Add lemon");
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
















        //tostring
        public override string ToString()
        {
            return (size.ToString() + " Warrior Water");
        }



    }
}
