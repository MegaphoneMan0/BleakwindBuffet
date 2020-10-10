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
     * Class name: MadOtarGrits.cs
     * Purpose: To track Mad Otar Grits
     */
    public class MadOtarGrits:Side
    {

        //special instructions


        /// <summary>
        /// The special instuctions for Mad Otar Grits
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
        /// The size of the Mad Otar Grits
        /// </summary>
        public override Size Size { get; set; }
        private Size size = Size.Small;



        /// <summary>
        /// The Price of the Mad Otar Grits
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
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter

        }//price


        /// <summary>
        /// The amount of calories in the Mad Otar Grits
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
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories



       






        //to string

        /// <summary>
        /// ToString override for Mad Otar Grits
        /// </summary>
        /// <returns>Mad Otar Grits string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Mad Otar Grits");
        }


    }
}
