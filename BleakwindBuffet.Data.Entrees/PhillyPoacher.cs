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
    class PhillyPoacher
    {


        //standard

        private double price = 7.23;
        private uint calories = 784;
        private List<String> specialInstructions;

        public double getPrice()
        {
            return price;
        }

        public uint getCalories()
        {
            return calories;
        }

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }







    }
}
