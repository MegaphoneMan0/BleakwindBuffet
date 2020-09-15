using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Drinks
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


    }
}
