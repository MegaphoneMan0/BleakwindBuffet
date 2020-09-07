using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: GardenOrcOmelette.cs
     * Purpose: To track Garden Orc Omelette: Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
     */
    public class GardenOrcOmelette
    {


        /// <summary>
        /// The special instuctions for the Garden Orc Omelette
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }//get

        }//SpecialInstructions








        //properties


        /// <summary>
        /// Price of the Garden Orc Omelette
        /// </summary>
        public double Price { get; } = 4.57;


        /// <summary>
        /// Calories of the Garden Orc Omelette
        /// </summary>
        public uint Calories { get; } = 404;


        /// <summary>
        /// Boolean which indicates if there is broccoli on the order
        /// </summary>
        public bool Broccoli { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there are mushrooms on the order
        /// </summary>
        public bool Mushrooms { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is a tomato on the order
        /// </summary>
        public bool Tomato { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is a cheddar on the order
        /// </summary>
        public bool Cheddar { get; set; } = true;






        //to string


        /// <summary>
        /// toString override for Garden Orc Omelette
        /// </summary>
        /// <returns>Garden Orc Omelette string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }



    }
}
