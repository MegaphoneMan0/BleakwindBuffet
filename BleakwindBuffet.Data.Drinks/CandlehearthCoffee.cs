using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: CandlehearthCoffee.cs
     * Purpose: To track Candlehearth Coffee
     */
    public class CandlehearthCoffee
    {



        //standard
        private double smallPrice = 0.75;
        private double mediumPrice = 1.25;
        private double largePrice = 1.75;

        private uint smallCalories = 7;
        private uint mediumCalories = 10;
        private uint largeCalories = 20;

        private List<string> specialInstructions;




        //unique

        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;
        
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


        public bool getDecaf()
        {
            return decaf;
        }

        public void setDecaf(bool b)
        {
            decaf = b;
            
        }



        public bool getRoomForCream()
        {
            return roomForCream;
        }

        public void setRoomForCream(bool b)
        {
            roomForCream = b;
            if (roomForCream == true)
            {
                specialInstructions.Add("Add cream");
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
            return (size.ToString() + " Candlehearth Coffee");
        }















    }
}
