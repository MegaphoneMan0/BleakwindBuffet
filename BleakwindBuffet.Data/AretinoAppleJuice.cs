using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{



    /*
     * Author: John Solomon
     * Class name: AretinoAppleJuice.cs
     * Purpose: To track Aretino Apple Juice
     */
    public class AretinoAppleJuice
    {

        //standard


        /// <summary>
        /// The special instuctions for Aretino Apple Juice
        /// </summary>
        public List<String> SpecialInstructions { get; }//SpecialInstructions

        /// <summary>
        /// The size of the Aretino Apple juice
        /// </summary>
        public Size Size { get; set; } = Size.Small;//Size

        //unique

        private bool ice = false;

        /// <summary>
        /// If there is or is not Ice in the Aretino Apple Juice
        /// </summary>
        public bool Ice
        {
            get { return ice; }//getter
            set { ice = value;
                if (ice == true)
                {
                    SpecialInstructions.Add("Add ice");
                }//if
            }//setter
        }//Ice

        /// <summary>
        /// The Price of the Aretino Apple Juice
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
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
            
        }//price


        /// <summary>
        /// The amount of calories in Aretino Apple Juice
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
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories




        /// <summary>
        /// ToString() override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Size.ToString() + " Aretino Apple Juice");
        }//ToString



        





    }//aretinoAppleJuice
}//BleakwindBuffet.Data.Drinks
