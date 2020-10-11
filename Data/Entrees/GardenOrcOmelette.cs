using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: GardenOrcOmelette.cs
     * Purpose: To track Garden Orc Omelette: Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
     */
    public class GardenOrcOmelette: Entree, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The special instuctions for the Garden Orc Omelette
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }//get

        }//SpecialInstructions








        //properties


        /// <summary>
        /// Price of the Garden Orc Omelette
        /// </summary>
        public override double Price { get; } = 4.57;


        /// <summary>
        /// Calories of the Garden Orc Omelette
        /// </summary>
        public override uint Calories { get; } = 404;


        /// <summary>
        /// Boolean which indicates if there is broccoli on the order
        /// </summary>
        public bool Broccoli { get { return broccoli; } set { broccoli = value; PropertyChanged(this, new PropertyChangedEventArgs("Broccoli")); } }
        private bool broccoli = true;

        /// <summary>
        /// Boolean which indicates if there are mushrooms on the order
        /// </summary>
        public bool Mushrooms { get { return mushrooms; } set { mushrooms = value; PropertyChanged(this, new PropertyChangedEventArgs("Mushrooms")); } }
        private bool mushrooms = true;


        /// <summary>
        /// Boolean which indicates if there is a tomato on the order
        /// </summary>
        public bool Tomato { get { return tomato; } set { tomato = value; PropertyChanged(this, new PropertyChangedEventArgs("Tomato")); } } 
        private bool tomato = true;


        /// <summary>
        /// Boolean which indicates if there is a cheddar on the order
        /// </summary>
        public bool Cheddar { get { return cheddar; } set { cheddar = value; PropertyChanged(this, new PropertyChangedEventArgs("Cheddar")); } } 
        private bool cheddar = true;






        //to string


        /// <summary>
        /// toString override for Garden Orc Omelette
        /// </summary>
        /// <returns>Garden Orc Omelette string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }



    }
}
