using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;
using BleakwindBuffet.Data.Interfaces;
using System.Collections.Specialized;
using System.Collections;

namespace BleakwindBuffet.Data
{
    /*
     * Author: John Solomon
     * Class name: Order.cs
     * Purpose: To represent the full order in the POS project in the main branch. Degridated class, not used in the website branch
     */
    class Order : INotifyPropertyChanged //, INotifyCollectionChanged , ICollection<IOrderItem>
    {

        List<IOrderItem> itemsInTheOrder;





        public event CollectionChangeEventHandler CollectionChanged;


        public event PropertyChangedEventHandler PropertyChanged;




        /*

        /// <summary>
        /// Unsure what this does
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            //IEnumerator enumerator = itemsInTheOrder;

            //I have no idea how this is supposed to work, so I'm just going to comment it out
            
            foreach (IOrderItem orderItem in itemsInTheOrder)
            {
                enumerator. = orderItem;
            }
            

            //return enumerator;


            return (IEnumerator)GetEnumerator();


        }

         

        /// <summary>
        /// Unsure what this does
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IOrderItem> GetEnumerator()
        {
            //IEnumerator<IOrderItem> enumerator;

           


        }
        */

        /// <summary>
        /// if the order is or is not read only
        /// </summary>
        public bool IsReadOnly { get; set; }


        /// <summary>
        /// the amount of IOrderItems in itemsInTheOrder
        /// </summary>
        /// <returns></returns>
        public int Count { get; set; }


        /// <summary>
        /// ICollection IOrderItem
        /// </summary>
        /// <param name="orderItems"></param>
        /// <param name="i"></param>
        public void CopyTo(IOrderItem[] orderItems, int i)
        {

        }

        /// <summary>
        /// checks the list to see if it contains the given IOrderItem
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(IOrderItem item)
        {
            if (itemsInTheOrder.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// ICollection's Clear()
        /// </summary>
        public void Clear()
        {

        }

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
        public bool Remove(IOrderItem item)
        {
            if (Contains(item))
            {
                itemsInTheOrder.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }



        







    }
}
