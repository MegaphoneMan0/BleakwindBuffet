using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: CandlehearthCoffee.cs
     * Purpose: To track Candlehearth Coffee
     */
    public class CandlehearthCoffee
    {

        //Special Instructions


        /// <summary>
        /// The special instuctions for Candlehearth Coffee
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Add Cream");

                return instructions;
            }//get

        }//SpecialInstructions


        //properties

        /// <summary>
        /// The size of the Candlehearth Coffee
        /// </summary>
        public Size Size { get; set; } = Size.Small;//Size

        /// <summary>
        /// If the coffee is or is not decaf
        /// </summary>
        public bool Decaf { get; set; } = false;//decaf


        /// <summary>
        /// If there is or is not Ice in the Candlehearth Coffee
        /// </summary>
        public bool Ice { get; set; } = false;//Ice


        /// <summary>
        /// Indicates if there is or is not room for cream in the coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;//cream


        /// <summary>
        /// The Price of the Coffee
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
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter

        }//price


        /// <summary>
        /// The amount of calories in the Coffee
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
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories




        //toString

        /// <summary>
        /// To string override for candlehearth coffee
        /// </summary>
        /// <returns>Candlehearth Coffee string</returns>
        public override string ToString()
        {
            if(Decaf) return (Size.ToString() + " Decaf Candlehearth Coffee");

            return (Size.ToString() + " Candlehearth Coffee");
        }


    }//class
}//namespace
