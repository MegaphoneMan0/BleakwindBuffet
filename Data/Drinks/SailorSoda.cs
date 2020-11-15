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
     * Class name: SailorSoda
     * Purpose: To track sailor soda
     */
    public class SailorSoda : Drink, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// The description of the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }



        /// <summary>
        /// The special instuctions for Sailor Soda
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice) instructions.Add("Add Ice");

                return instructions;
            }

        }//SpecialInstructions









        //properties
        private SodaFlavor flavor = SodaFlavor.Cherry;




        //unique

        /// <summary>
        /// The flavor of the Sailor Soda
        /// </summary>
        public SodaFlavor Flavor { get { return flavor; } set { flavor = value; NotifyPropertyChanged("Flavor"); } }


        /// <summary>
        /// The size of the Sailor Soda
        /// </summary>
        public override Size Size { get { return size; } set { size = value; NotifyPropertyChanged("Size"); } } //Size
        private Size size = Size.Small;


        /// <summary>
        /// If there is or is not Ice in the Sailor Soda
        /// </summary>
        public bool Ice { get { return ice; } set { ice = value; NotifyPropertyChanged("Ice"); } } //setter
        private bool ice = true;


        /// <summary>
        /// The Price of the Sailor Soda
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
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }

        }//price


        /// <summary>
        /// The amount of calories in Sailor Soda
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
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
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
            Flavor = SodaFlavor.Blackberry;



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


                if (s.Equals("Blackberry"))
                {
                    Flavor = SodaFlavor.Blackberry;
                }
                if (s.Equals("Cherry"))
                {
                    Flavor = SodaFlavor.Cherry;
                }
                if (s.Equals("Grapefruit"))
                {
                    Flavor = SodaFlavor.Grapefruit;
                }
                if (s.Equals("Lemon"))
                {
                    Flavor = SodaFlavor.Lemon;
                }
                if (s.Equals("Peach"))
                {
                    Flavor = SodaFlavor.Peach;
                }
                if (s.Equals("Watermelon"))
                {
                    Flavor = SodaFlavor.Watermelon;
                }


            }

        }


        // This method is called by the Set accessor of each property.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        //tostring
        /// <summary>
        /// Overriden ToString()
        /// </summary>
        /// <returns>Sailor Soda string</returns>
        public override string ToString()
        {
            return (Size.ToString() + " " + Flavor + " Sailor Soda");
        }






    }
}
