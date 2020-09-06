using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: SmokehouseSkeleton.cs
     * Purpose: To track Smokehouse Skeleton: Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
     */
    public class SmokehouseSkeleton
    {


        //special instructions

        /// <summary>
        /// The special instuctions for the Smokehouse Skeleton
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!SausageLink) instructions.Add("Hold sausage link");
                if (!Egg) instructions.Add("Hold egg");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");

                return instructions;
            }//get

        }//SpecialInstructions









        //properties


        /// <summary>
        /// Price of the Smokehouse Skeleton
        /// </summary>
        public double Price { get; } = 5.62;


        /// <summary>
        /// Calories of the Smokehouse Skeleton
        /// </summary>
        public uint Calories { get; } = 602;


        /// <summary>
        /// Boolean which indicates if there is sausage on the order
        /// </summary>
        public bool SausageLink { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is egg on the order
        /// </summary>
        public bool Egg { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is hash browns on the order
        /// </summary>
        public bool HashBrowns { get; set; } = true;


        /// <summary>
        /// Boolean which indicates if there is pancake on the order
        /// </summary>
        public bool Pancake { get; set; } = true;














        //to string


        /// <summary>
        /// Overriden ToString() method
        /// </summary>
        /// <returns>Smokehouse Skeleton as a string</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }





    }//class
}//namespace
