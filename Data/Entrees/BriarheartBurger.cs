using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: BriarheartBurger
     * Purpose: To track briarheart burgers: Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
     */
    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;
        //specialInstructions

        /// <summary>
        /// The special instuctions for Briarheart Burger
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");

                return instructions;
            }//get

        }//SpecialInstructions




        //properties


        /// <summary>
        /// Price of the Briarheart Burger
        /// </summary>
        public override double Price { get; } = 6.32;


        /// <summary>
        /// Calories of the Briarheart Burger
        /// </summary>
        public override uint Calories { get; } = 743;

        
        /// <summary>
        /// Boolean which indicates if there is a bun on the order
        /// </summary>
        public bool Bun { get { return bun; } set { bun = value; NotifyPropertyChanged("Bun"); } } //bun
        private bool bun = true;

        /// <summary>
        /// Boolean which indicates if there is ketchup on the order
        /// </summary>
        public bool Ketchup { get { return ketchup; } set { ketchup = value; NotifyPropertyChanged("Ketchup"); } } 
        private bool ketchup = true;


        /// <summary>
        /// Boolean which indicates if there is mustard on the order
        /// </summary>
        public bool Mustard { get { return mustard; } set { mustard = value; NotifyPropertyChanged("Mustard"); } } //mustard
        private bool mustard = true;


        /// <summary>
        /// Boolean which indicates if there is pickle on the order
        /// </summary>
        public bool Pickle { get { return pickle; } set { pickle = value; NotifyPropertyChanged("Pickle"); } } 
        private bool pickle = true;


        /// <summary>
        /// Boolean which indicates if there is cheese on the order
        /// </summary>
        public bool Cheese { get { return cheese; } set { cheese = value; NotifyPropertyChanged("Cheese"); } } 
        private bool cheese = true;


        // This method is called by the Set accessor of each property.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// This method sets all of the ingredients to default false, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public override void setIngredients(BindingList<string> vs)
        {
            Bun = false;
            Ketchup = false;
            Mustard = false;
            Pickle = false;
            Cheese = false;



            foreach (string s in vs)
            {

                if (s.Equals( "Bun"))
                {
                    Bun = true;
                }
                if (s.Equals("Ketchup"))
                {
                    Ketchup = true;
                }
                if (s.Equals("Mustard"))
                {
                    Mustard = true;
                }
                if (s.Equals("Pickle"))
                {
                    Pickle = true;
                }
                if (s.Equals("Cheese"))
                {
                    Cheese = true;
                }

            }

        }



        //toString()

        /// <summary>
        /// To String override
        /// </summary>
        /// <returns>Briarheart Burger string</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }//toString



    }//class
}//namespace
