using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /*
     * Author: John Solomon
     * Class name: SailorSoda
     * Purpose: To track sailor soda
     */
    public class SailorSoda
    {

        //standard
        private double smallPrice = 1.42;
        private double mediumPrice = 1.74;
        private double largePrice = 2.07;

        private uint smallCalories = 117;
        private uint mediumCalories = 153;
        private uint largeCalories = 205;

        private List<string> specialInstructions;

        





        //unique

        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;



        public bool getIce()
        {
            return ice;
        }

        public void setIce(bool b)
        {
            ice = b;
            if (ice == false)
            {
                specialInstructions.Add("Hold ice");
            }
        }


        public Size getSize()
        {
            return size;
        }

        public void setSize(Size b)
        {
            size = b;
           
        }


        public SodaFlavor getFlavor()
        {
            return flavor;
        }

        public void setFlavor(SodaFlavor b)
        {
            flavor = b;
            
        }












        public double getPrice()
        {
            if (size == Size.Small)
            {
                return smallPrice;
            }
            else if (size == Size.Medium)
            {
                return mediumPrice;
            }
            else 
            {
                return largePrice;
            }
        }

        public uint getCalories()
        {
            if (size == Size.Small)
            {
                return smallCalories;
            }
            else if (size == Size.Medium)
            {
                return mediumCalories;
            }
            else
            {
                return largeCalories;
            }
        }

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }

        public override string ToString()
        {
            return (size.ToString() + " " + flavor + " Sailor Soda");
        }






    }
}
