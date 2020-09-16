using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Abstract;

namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: ThugsTBone.cs
     * Purpose: To track Thugs T-Bones: Juicy T-Bone not much else to say.
     */
    public class ThugsTBone:Entree
    {

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
