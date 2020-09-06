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

        

        /// <summary>
        /// Price of the Double Draugr
        /// </summary>
        public double Price { get; } = 7.32;

        /// <summary>
        /// Calories of the Double Draugr
        /// </summary>
        public uint Calories { get; } = 843;

        /// <summary>
        /// The special instuctions for Double Draugr
        /// </summary>
        public List<String> SpecialInstructions { get; }//SpecialInstructions

        

        
        /// <summary>
        /// ToString override for the Double Draugr
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }







        //unique
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;



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




        public bool getTomato()
        {
            return tomato;
        }

        public void setTomato(bool b)
        {
            tomato = b;
            if (tomato == false)
            {
                specialInstructions.Add("Hold tomato");
            }
        }



        public bool getLettuce()
        {
            return lettuce;
        }

        public void setLettuce(bool b)
        {
            lettuce = b;
            if (lettuce == false)
            {
                specialInstructions.Add("Hold lettuce");
            }
        }



        public bool getMayo()
        {
            return mayo;
        }

        public void setMayo(bool b)
        {
            mayo = b;
            if (mayo == false)
            {
                specialInstructions.Add("Hold mayo");
            }
        }











    }
}
