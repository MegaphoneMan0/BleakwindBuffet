using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;
using System.Net;
using System.Linq;

namespace BleakwindBuffet.Data
{

    /*
     * Author: John Solomon
     * Class name: Combo.cs
     * Purpose: A combo class that has an entree, drink, and side
     */
    class Combo : IOrderItem , INotifyPropertyChanged
    {
        public string Description
        {
            get
            {
                return "Combo";
            }
        }

        /// <summary>
        /// the entree portion of the combo
        /// </summary>
        public IOrderItem Entree { get { return Entree; } 
            set 
            { 
                Entree = value; 
                NotifyPropertyChanged("Entree"); 
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");

            }

        }


        /// <summary>
        /// the drink portion of the combo
        /// </summary>
        public IOrderItem Drink { get { return Drink; }
            set
            {
                Drink = value;
                NotifyPropertyChanged("Drink");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");

            }

        }


        /// <summary>
        /// the side portion of the combo
        /// </summary>
        public IOrderItem Side { get { return Side; }
            set
            {
                Side = value;
                NotifyPropertyChanged("Side");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");

            }

        }


        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// changes the event handler when a property is changed
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        /// <summary>
        /// The price of the combo
        /// </summary>
        public double Price
        {
            get { return Price; }
            set
            {
                Price = value;
                

            }

        }

        /// <summary>
        /// The calories of the combo
        /// </summary>
        public uint Calories
        {
            get { return Calories; }
            set
            {
                Calories = value;


            }

        }

        /// <summary>
        /// set the ingredients of the combo (will go unused most likely in this class)
        /// </summary>
        /// <param name="vs"></param>
        public void setIngredients(BindingList<string> vs) 
        { 
            
        }

        /// <summary>
        /// Retruns the special instructions of all pieces of the combo
        /// </summary>
        public List<string> SpecialInstructions { get; }



        Combo()
        {

        }


        /// <summary>
        /// Constructor for the combo which takes all of the components of a combo as IOrderItems
        /// </summary>
        /// <param name="Entree"></param>
        /// <param name="Drink"></param>
        /// <param name="Side"></param>
        Combo(IOrderItem Entree,IOrderItem Drink, IOrderItem Side)
        {
            this.Entree = Entree;
            this.Drink = Drink;
            this.Side = Side;


            List<string> esp = new List<string>();
            esp.Add(Entree.GetType().Name);
            esp.Concat(Entree.SpecialInstructions);

            List<string> dsp = new List<string>();
            esp.Add(Drink.GetType().Name);
            esp.Concat(Drink.SpecialInstructions);

            List<string> ssp = new List<string>();
            esp.Add(Side.GetType().Name);
            esp.Concat(Side.SpecialInstructions);



            List<string> realSI = new List<string>();

            realSI.Concat(esp);
            realSI.Concat(dsp);
            realSI.Concat(ssp);


            SpecialInstructions = realSI;

        }





        /*

        public List<string> SpecialInstructionsCombine() 
        {
            List<string> vs = new List<string>();





            return vs;        
        }

        */


    }
}
