using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;



namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: MarkarthMilk
     * Purpose: To track Markarth Milk
     */
    public class MarkarthMilk : Drink
    {


        //Special Instructions


        /// <summary>
        /// The special instuctions for Markarth Milk
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice) instructions.Add("Add Ice");

                return instructions;

            }
        }//SpecialInstructions










        //properties

        /// <summary>
        /// The size of the Markarth Milk
        /// </summary>
        public override Size Size { get { return size; } set { size = value; } }
        private Size size = Size.Small;

        /// <summary>
        /// If there is or is not Ice in the Markarth Milk
        /// </summary>
        public bool Ice { get { return ice; } set { ice = value; } }
        private bool ice = false;

        /// <summary>
        /// The Price of the Markarth Milk
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }

        }//price


        /// <summary>
        /// The amount of calories in Markarth Milk
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }//calories

      










        //to string

        /// <summary>
        /// ToString override for Markarth Milk
        /// </summary>
        /// <returns>Markart Milk string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Markarth Milk");
        }



    }
}
