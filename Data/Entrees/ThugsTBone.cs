using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: ThugsTBone.cs
     * Purpose: To track Thugs T-Bones: Juicy T-Bone not much else to say.
     */
    public class ThugsTBone:Entree, INotifyPropertyChanged
    {

        // This BindingSource binds the list to the DataGridView control.
        public event PropertyChangedEventHandler PropertyChanged;
        //special instuctions
        /// <summary>
        /// The special instuctions for Thugs T-Bone
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();

                return instructions;
            }//get

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


        //standard

        /// <summary>
        /// price of ThugsTBone
        /// </summary>
        public override double Price { get;  } = 6.44;
        /// <summary>
        /// calories in ThugsTBone
        /// </summary>
        public override uint Calories { get;  } = 982;







        /// <summary>
        /// This method sets all of the ingredients to default false, then adds ingredients back based on the provided list
        /// </summary>
        /// <param name="vs"></param>
        public override void setIngredients(BindingList<string> vs)
        {
            

        }









        //tostring

        /// <summary>
        /// ToString override for Thugs T-Bone
        /// </summary>
        /// <returns>Thugs T-Bone as a string</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }




    }
}
