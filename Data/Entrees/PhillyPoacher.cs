﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: PhillyPoacher.cs
     * Purpose: To track Philly Poacher: Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.
     */
    public class PhillyPoacher : Entree
    {


        //special instructions
        /// <summary>
        /// The special instuctions for the Philly Poacher
        /// </summary>
        public override List<String> SpecialInstructions
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
        public override double Price { get; } = 7.23;


        /// <summary>
        /// Calories of the Philly Poacher
        /// </summary>
        public override uint Calories { get; } = 784;


        /// <summary>
        /// Boolean which indicates if there is sirloin on the order
        /// </summary>
        public bool Sirloin { get { return sirloin; } set { sirloin = value; } }
        private bool sirloin = true;


        /// <summary>
        /// Boolean which indicates if there is onion on the order
        /// </summary>
        public bool Onion { get { return onion; } set { onion = value; } } 
        private bool onion = true;


        /// <summary>
        /// Boolean which indicates if there is roll on the order
        /// </summary>
        public bool Roll { get { return roll; } set { roll = value; } } 
        private bool roll = true;











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
