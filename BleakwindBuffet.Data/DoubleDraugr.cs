using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: DoubleDraugr
     * Purpose: To track Double Draugr burgers: Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.
     */
    public class DoubleDraugr
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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");

                return instructions;
            }//get

        }//SpecialInstructions




        //properties


        /// <summary>
        /// Price of the Double Draugr
        /// </summary>
        public double Price { get; } = 7.32;

        /// <summary>
        /// Calories of the Double Draugr
        /// </summary>
        public uint Calories { get; } = 843;

        
        /// <summary>
        /// Boolean which indicates if there is a bun on the order
        /// </summary>
        public bool Bun { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is ketchup on the order
        /// </summary>
        public bool Ketchup { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is mustard on the order
        /// </summary>
        public bool Mustard { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is pickle on the order
        /// </summary>
        public bool Pickle { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is cheese on the order
        /// </summary>
        public bool Cheese { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is tomato on the order
        /// </summary>
        public bool Tomato { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is Lettuce on the order
        /// </summary>
        public bool Lettuce { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is Mayo on the order
        /// </summary>
        public bool Mayo { get; set; } = true;




        //toString

        /// <summary>
        /// ToString override for the Double Draugr
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }


    }//class
}//namespace
