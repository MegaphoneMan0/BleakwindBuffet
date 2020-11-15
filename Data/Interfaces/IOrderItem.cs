using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace BleakwindBuffet.Data.Interfaces
{
    public interface IOrderItem
    {
        /// <summary>
        /// The price of an IOrderItem
        /// </summary>
        double Price { get; }
    
        /// <summary>
        /// Calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// any special instructions for the item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// This method sets the ingredients of the item based on a given list
        /// </summary>
        /// <param name="vs"></param>
        void setIngredients(BindingList<string> vs);

        /// <summary>
        /// A description of the item
        /// </summary>
        string Description { get; }

    }
}
