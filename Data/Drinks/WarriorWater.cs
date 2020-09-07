using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: WarriorWater.cs
     * Purpose: To track Warrior Water
     */
    public class WarriorWater
    {
        //special instructions
        /// <summary>
        /// The special instuctions for Warrior Water
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");


                return instructions;
            }//get

        }//SpecialInstructions





        //properties

        


        public bool Ice { get; set; } = true;
        public bool Lemon { get; set; } = false;


        /// <summary>
        /// The size of the Warrior Water
        /// </summary>
        public Size Size { get; set; } = Size.Small;//Size


        /// <summary>
        /// The Price of the Warrior Water
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public double Price
        {
            get
            {
                return 0;
            }//getter

        }//price


        /// <summary>
        /// The amount of calories in Warrior Water
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public uint Calories
        {
            get
            {
                return 0;
            }//getter
        }//calories







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
