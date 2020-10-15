using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;
using BleakwindBuffet.Data.Interfaces;


namespace BleakwindBuffet.Data
{
    class Order
    {

        List<IOrderItem> itemsInTheOrder;

        /// <summary>
        /// default constructor, sets the list to a new list
        /// </summary>
        Order()
        {
            itemsInTheOrder = new List<IOrderItem>();


        }

        /// <summary>
        /// adds an item to the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            itemsInTheOrder.Add(item);

        }

        /// <summary>
        /// removes an item from the list
        /// </summary>
        /// <param name="item"></param>
        public void Remove (IOrderItem item)
        {
            itemsInTheOrder.Remove(item);
        }


    }
}
