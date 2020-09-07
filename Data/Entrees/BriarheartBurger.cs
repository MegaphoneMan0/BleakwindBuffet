using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: BriarheartBurger
     * Purpose: To track briarheart burgers: Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
     */
    public class BriarheartBurger
    {

        //specialInstructions

        /// <summary>
        /// The special instuctions for Briarheart Burger
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");

                return instructions;
            }//get

        }//SpecialInstructions




        //properties

        /// <summary>
        /// Price of the Briarheart Burger
        /// </summary>
        public double Price { get; } = 6.32;

        /// <summary>
        /// Calories of the Briarheart Burger
        /// </summary>
        public uint Calories { get; } = 743;

        
        /// <summary>
        /// Boolean which indicates if there is a bun on the order
        /// </summary>
        public bool Bun { get; set; } = true;//bun


        /// <summary>
        /// Boolean which indicates if there is ketchup on the order
        /// </summary>
        public bool Ketchup { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is mustard on the order
        /// </summary>
        public bool Mustard { get; set; } = true;//mustard


        /// <summary>
        /// Boolean which indicates if there is pickle on the order
        /// </summary>
        public bool Pickle { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is cheese on the order
        /// </summary>
        public bool Cheese { get; set; } = true;





        //toString()

        /// <summary>
        /// To String override
        /// </summary>
        /// <returns>Briarheart Burger string</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }//toString



    }//class
}//namespace
