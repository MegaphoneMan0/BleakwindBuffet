using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Abstract
{
    public abstract class Drink : IOrderItem
    {

        /// <summary>
        /// Size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// This method sets all of the ingredients to default fault, small, or blackberry, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public abstract void setIngredients(BindingList<string> vs);


    }
}
