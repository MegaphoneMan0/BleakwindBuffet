using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;


namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree :IOrderItem
    {
        /// <summary>
        /// Price of entrees
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories of entrees
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// SpecialInstructions for entrees
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }




    }
}
