using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: ThugsTBone.cs
     * Purpose: To track Thugs T-Bones: Juicy T-Bone not much else to say.
     */
    public class ThugsTBone
    {

        //special instuctions
        /// <summary>
        /// The special instuctions for Thugs T-Bone
        /// </summary>
        public List<String> SpecialInstructions
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
        public double Price { get; set; } = 6.44;
        /// <summary>
        /// calories in ThugsTBone
        /// </summary>
        public uint Calories { get; set; } = 982;

       
        














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
