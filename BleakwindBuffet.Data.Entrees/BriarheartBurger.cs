using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: BriarheartBurger
     * Purpose: To track briarheart burgers: Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
     */
    public class BriarheartBurger
    {

        //standard

        private double price = 6.32;
        private uint calories = 743;
        private List<String> specialInstructions;

        public double getPrice()
        {
            return price;
        }

        public uint getCalories()
        {
            return calories;
        }

        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }

        public override string ToString() 
        {
            return "Briarheart Burger";
        }





        //unique
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;


        public bool getBun()
        {
            return bun;
        }

        public void setBun(bool b)
        {
            bun = b;
            if(bun == false)
            {
                specialInstructions.Add("Hold bun");
            }
        }




        public bool getKetchup()
        {
            return ketchup;

        }

        public void setKetchup(bool b)
        {
            ketchup = b;
            if (ketchup == false)
            {
                specialInstructions.Add("Hold ketchup");
            }
        }




        public bool getMustard()
        {
            return mustard;
        }

        public void setMustard(bool b)
        {
            mustard = b;
            if (mustard == false)
            {
                specialInstructions.Add("Hold mustard");
            }
        }




        public bool getPickle()
        {
            return pickle;
        }

        public void setPickle(bool b)
        {
            pickle = b;
            if (pickle == false)
            {
                specialInstructions.Add("Hold pickle");
            }
        }




        public bool getCheese()
        {
            return cheese;
        }

        public void setCheese(bool b)
        {
            cheese = b;
            if (cheese == false)
            {
                specialInstructions.Add("Hold cheese");
            }
        }






























    }
}
