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
     * Class name: VokunSalad.cs
     * Purpose: To track Vokun Salad
     */
    public class VokunSalad:Side, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;
        //special instructions

        /// <summary>
        /// The special instuctions for Vokun Salad
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
        /// The size of the Vokun Salad
        /// </summary>
        public override Size Size { get; set; }
        private Size size = Size.Small;



        /// <summary>
        /// The Price of the Vokun Salad
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
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter

        }//price


        /// <summary>
        /// The amount of calories in Vokun Salad
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories









        //tostring

        /// <summary>
        /// ToString override for Vokun Salad
        /// </summary>
        /// <returns>Vokun Salad string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Vokun Salad");
        }








    }//class
}//namespace



