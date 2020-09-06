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

        /// <summary>
        /// The special instuctions for Briarheart Burger
        /// </summary>
        public List<String> SpecialInstructions { get; }//SpecialInstructions

        /// <summary>
        /// Price of the Briarheart Burger
        /// </summary>
        public double Price { get; } = 6.32;

        /// <summary>
        /// Calories of the Briarheart Burger
        /// </summary>
        public uint Calories { get; } = 743;

        /// <summary>
        /// To String override
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return "Briarheart Burger";
        }//toString





        //unique
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// Boolean which indicates if there is a bun on the order
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }//get
            set
            {
                bun = value;
                if (bun == false)
                {
                    SpecialInstructions.Add("Hold bun");
                }//if
            }//set
        }//bun

        



        /// <summary>
        /// Boolean which indicates if there is ketchup on the order
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }//get
            set
            {
                ketchup = value;
                if (ketchup == false)
                {
                    SpecialInstructions.Add("Hold ketchup");
                }//if
            }//set
        }//ketchup






        /// <summary>
        /// Boolean which indicates if there is mustard on the order
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }//get
            set
            {
                mustard = value;
                if (mustard == false)
                {
                    SpecialInstructions.Add("Hold mustard");
                }//if
            }//set
        }//mustard




        /// <summary>
        /// Boolean which indicates if there is pickle on the order
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }//get
            set
            {
                pickle = value;
                if (pickle == false)
                {
                    SpecialInstructions.Add("Hold pickle");
                }//if
            }//set
        }//pickle




        /// <summary>
        /// Boolean which indicates if there is cheese on the order
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }//get
            set
            {
                cheese = value;
                if (cheese == false)
                {
                    SpecialInstructions.Add("Hold cheese");
                }//if
            }//set
        }//cheese






























    }
}
