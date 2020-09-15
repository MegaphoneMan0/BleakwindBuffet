using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Price for sides
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories for sides
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special instructions for sides
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// base Size getter setter for all sides
        /// </summary>
        public abstract Size Size { get; set; }


    }
}
