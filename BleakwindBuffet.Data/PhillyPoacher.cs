using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: PhillyPoacher.cs
     * Purpose: To track Philly Poacher: Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.
     */
    public class PhillyPoacher
    {


        //special instructions
        private List<String> specialInstructions;

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }







        //properties




        //standard

        private double price = 7.23;
        private uint calories = 784;

        public double getPrice()
        {
            return price;
        }

        public uint getCalories()
        {
            return calories;
        }

        

        



        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        public bool getSirloin()
        {
            return sirloin;
        }

        public void setSirloin(bool b)
        {
            sirloin = b;
            if (sirloin == false)
            {
                specialInstructions.Add("Hold sirloin");
            }
        }


        public bool getOnion()
        {
            return onion;
        }

        public void setOnion(bool b)
        {
            onion = b;
            if (onion == false)
            {
                specialInstructions.Add("Hold onion");
            }
        }



        public bool getRoll()
        {
            return roll;
        }

        public void setRoll(bool b)
        {
            roll = b;
            if (roll == false)
            {
                specialInstructions.Add("Hold roll");
            }
        }




        //to string

        public override string ToString()
        {
            return "Philly Poacher";
        }






    }
}
