using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Abstract
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// A description of the side
        /// </summary>
        public abstract string Description { get; }

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

        /// <summary>
        /// This method sets all of the ingredients to default false (or small), then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public abstract void setIngredients(BindingList<string> vs);
    }
}
