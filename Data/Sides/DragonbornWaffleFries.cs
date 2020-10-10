using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /*
     * Author: John Solomon
     * Class name: DragonbornWaffleFries.cs
     * Purpose: To track Dragonborn Waffle Fries
     */
    public class DragonbornWaffleFries : Side
    {


        //special instructions


        /// <summary>
        /// The special instuctions for Dragonborn Waffle Fries
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                return instructions;
            }//get

        }//SpecialInstructions




        //properties


        /// <summary>
        /// The size of the Dragonborn Waffle Fries
        /// </summary>
        public override Size Size { get { return size; } set { size = value; } } 
        private Size size = Size.Small;


        /// <summary>
        /// The Price of the Dragonborn Waffle Fries
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
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter

        }//price


        /// <summary>
        /// The amount of calories in the Dragonborn Waffle Fries
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
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories



        //toString


        /// <summary>
        /// ToString override for Dragonborn Waffle Fries
        /// </summary>
        /// <returns>Dragonborn Waffle Fries string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Dragonborn Waffle Fries");
        }



       
    }
}
