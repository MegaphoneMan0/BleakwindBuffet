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

        //standard instuctions
        private List<String> specialInstructions;

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }












        //properties


        //standard

        private double price = 6.44;
        private uint calories = 982;

        public double getPrice()
        {
            return price;
        }

        public uint getCalories()
        {
            return calories;
        }

        














        //tostring


        public override string ToString()
        {
            return "Thugs T-Bone";
        }




    }
}
