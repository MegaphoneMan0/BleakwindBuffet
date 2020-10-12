using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;



namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: CandlehearthCoffee.cs
     * Purpose: To track Candlehearth Coffee
     */
    public class CandlehearthCoffee : Drink , INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;

        //Special Instructions


        /// <summary>
        /// The special instuctions for Candlehearth Coffee
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Add Cream");

                return instructions;
            }

        }//SpecialInstructions

        // This method is called by the Set accessor of each property.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //properties

        /// <summary>
        /// The size of the Candlehearth Coffee
        /// </summary>
        public override Size Size { get { return size; } set { size = value; PropertyChanged(this, new PropertyChangedEventArgs("Size")); } }
        private Size size = Size.Small;

        /// <summary>
        /// If the coffee is or is not decaf
        /// </summary>
        public bool Decaf { get { return decaf; } set { decaf = value; PropertyChanged(this, new PropertyChangedEventArgs("Decaf")); } } //decaf
        private bool decaf = false;

        /// <summary>
        /// If there is or is not Ice in the Candlehearth Coffee
        /// </summary>
        public bool Ice { get { return ice; } set { ice = value; PropertyChanged(this, new PropertyChangedEventArgs("Ice")); } }
        private bool ice = false;


        /// <summary>
        /// Indicates if there is or is not room for cream in the coffee
        /// </summary>
        public bool RoomForCream { get { return roomForCream; } set { roomForCream = value; PropertyChanged(this, new PropertyChangedEventArgs("Room For Cream")); } } //cream
        private bool roomForCream = false;

        /// <summary>
        /// The Price of the Coffee
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
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }

        }//price


        /// <summary>
        /// The amount of calories in the Coffee
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
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }//calories


        /// <summary>
        /// This method sets all of the ingredients to default false, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public override void setIngredients(BindingList<string> vs)
        {
            Ice = false;
            Size = Size.Small;
            Decaf = false;
            RoomForCream = false;



            foreach (string s in vs)
            {

                if (s.Equals("Ice"))
                {
                    Ice = true;
                }
                if (s.Equals("Small"))
                {
                    Size = Size.Small;
                }
                if (s.Equals("Medium"))
                {
                    Size = Size.Medium;
                }
                if (s.Equals("Large"))
                {
                    Size = Size.Large;
                }
                if (s.Equals("Decaf"))
                {
                    Decaf = true;
                }
                if(s.Equals("Room For Cream"))
                {
                    RoomForCream = true;
                }


            }

        }

        //toString

        /// <summary>
        /// To string override for candlehearth coffee
        /// </summary>
        /// <returns>Candlehearth Coffee string</returns>
        public override string ToString()
        {
            if(Decaf) return (Size.ToString() + " Decaf Candlehearth Coffee");

            return (Size.ToString() + " Candlehearth Coffee");
        }


    }//class
}//namespace
