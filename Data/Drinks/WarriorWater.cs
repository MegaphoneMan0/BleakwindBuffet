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
     * Class name: WarriorWater.cs
     * Purpose: To track Warrior Water
     */
    public class WarriorWater : Drink, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;

        //special instructions
        /// <summary>
        /// The special instuctions for Warrior Water
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");


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
        /// Whether or not there is Ice in the warrior water
        /// </summary>
        public bool Ice { get { return ice; } set { ice = value; PropertyChanged(this, new PropertyChangedEventArgs("Ice")); } }
        private bool ice = true;

        /// <summary>
        /// Whether or not there s Lemon in the warrior water
        /// </summary>
        public bool Lemon { get { return lemon; } set { lemon = value; PropertyChanged(this, new PropertyChangedEventArgs("Lemon")); } } 
        private bool lemon = false;


        /// <summary>
        /// The size of the Warrior Water
        /// </summary>
        public override Size Size { get { return size; } set { size = value; PropertyChanged(this, new PropertyChangedEventArgs("Size")); } }
        private Size size = Size.Small;


        /// <summary>
        /// The Price of the Warrior Water
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override double Price
        {
            get
            {
                return 0;

            }
        }//price


        /// <summary>
        /// The amount of calories in Warrior Water
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                return 0;
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
            Lemon = false;


            foreach (string s in vs)
            {

                if (s.Equals("Ice"))
                {
                    Ice = true;
                }
                if (s.Equals("Lemon"))
                {
                    Lemon = true;
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


            }

        }



        //tostring


        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Warrior Water String</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Warrior Water");
        }


         
    }
}
