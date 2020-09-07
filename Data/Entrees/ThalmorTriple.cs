﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: ThalmorTriple.cs
     * Purpose: To track Thalmor Triple burgers: Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
     */
    public class ThalmorTriple
    {

        //specialInstructions

        /// <summary>
        /// The special instuctions for the Thalmor Triple
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");


                return instructions;
            }//get

        }//SpecialInstructions










        //properties


        /// <summary>
        /// Price of the Thalmor Triple
        /// </summary>
        public double Price { get; } = 8.32;

        /// <summary>
        /// Calories of the Thalmor Triple
        /// </summary>
        public uint Calories { get; } = 943;


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


        /// <summary>
        /// Boolean which indicates if there is bacon on the order
        /// </summary>
        public bool Bacon { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is egg on the order
        /// </summary>
        public bool Egg { get; set; } = true;



        











        //tostring

        /// <summary>
        /// Overrides toString
        /// </summary>
        /// <returns>returns Thalmor Triple as a string</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }





    }
}