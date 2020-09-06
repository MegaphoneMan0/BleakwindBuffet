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
        /// <summary>
        /// The special instuctions for the Philly Poacher
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");

                return instructions;
            }//get

        }//SpecialInstructions










        //properties



        /// <summary>
        /// Price of the Philly Poacher
        /// </summary>
        public double Price { get; } = 7.23;


        /// <summary>
        /// Calories of the Philly Poacher
        /// </summary>
        public uint Calories { get; } = 784;


        /// <summary>
        /// Boolean which indicates if there is sirloin on the order
        /// </summary>
        public bool Sirloin { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is onion on the order
        /// </summary>
        public bool Onion { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is roll on the order
        /// </summary>
        public bool Roll { get; set; } = true;

        


       






        //to string


        /// <summary>
        /// Overriden ToString() method
        /// </summary>
        /// <returns>Philly Poacher as a string</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }






    }
}
