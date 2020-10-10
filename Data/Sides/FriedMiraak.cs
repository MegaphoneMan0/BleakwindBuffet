﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /*
     * Author: John Solomon
     * Class name: FriedMiraak.cs
     * Purpose: To track Fried Miraak
     */
    public class FriedMiraak :Side, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;
        //special instructions


        /// <summary>
        /// The special instuctions for Fried Miraak
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
        /// The size of the Fried Miraak
        /// </summary>
        public override Size Size { get; set; } 
        private Size size = Size.Small;


        /// <summary>
        /// The Price of the Fried Miraak
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter

        }//price


        /// <summary>
        /// The amount of calories in the Fried Miraak
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }//getter
        }//calories







        //to string

        /// <summary>
        /// ToString override for Fried Miraak
        /// </summary>
        /// <returns>Fried Miraak string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Fried Miraak");
        }


    }
}
