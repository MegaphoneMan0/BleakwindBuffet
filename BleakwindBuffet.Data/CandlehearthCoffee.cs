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



        /// <summary>
        /// The special instuctions for Candlehearth Coffee
        /// </summary>
        public List<String> SpecialInstructions { get; }//SpecialInstructions

        /// <summary>
        /// The size of the Candlehearth Coffee
        /// </summary>
        public Size Size { get; set; } = Size.Small;//Size

        /// <summary>
        /// If the coffee is or is not decaf
        /// </summary>
        public bool Decaf { get; set; } = false;//decaf


        //unique

        private bool ice = false;
        private bool roomForCream = false;


        


        /// <summary>
        /// If there is or is not Ice in the Candlehearth Coffee
        /// </summary>
        public bool Ice
        {
            get { return ice; }//getter
            set
            {
                ice = value;
                if (ice == true)
                {
                    SpecialInstructions.Add("Add ice");
                }//if
            }//setter
        }//Ice

        




        /// <summary>
        /// Indicates if there is or is not room for cream in the coffee
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }//getter
            set 
            { 
                roomForCream = value;
                if (roomForCream == true)
                {
                    SpecialInstructions.Add("Add cream");
                }//if
            }//setter
        }//cream






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


        /// <summary>
        /// To string override for candlehearth coffee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Size.ToString() + " Candlehearth Coffee");
        }















    }
}
