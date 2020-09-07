using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: SailorSoda
     * Purpose: To track sailor soda
     */
    public class SailorSoda
    {

        /// <summary>
        /// The special instuctions for Sailor Soda
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice) instructions.Add("Add Ice");

                return instructions;
            }//get

        }//SpecialInstructions









        //properties





        //unique

        /// <summary>
        /// The size of the Sailor Soda
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;


        /// <summary>
        /// The size of the Sailor Soda
        /// </summary>
        public Size Size { get; set; } = Size.Small;//Size


        /// <summary>
        /// If there is or is not Ice in the Sailor Soda
        /// </summary>
        public bool Ice { get; set; } = true;//setter


        /// <summary>
        /// The Price of the Sailor Soda
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter

        }//price


        /// <summary>
        /// The amount of calories in Sailor Soda
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories











        //tostring
        /// <summary>
        /// Overriden ToString()
        /// </summary>
        /// <returns>Sailor Soda string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " " + Flavor + " Sailor Soda");
        }






    }
}
