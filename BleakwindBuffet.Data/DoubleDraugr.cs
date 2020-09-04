using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{

    /*
     * Author: John Solomon
     * Class name: DoubleDraugr
     * Purpose: To track Double Draugr burgers: Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.
     */
    public class DoubleDraugr
    {

        //standard

        private double price = 7.32;
        private uint calories = 843;
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
            return "Double Draugr";
        }







        //unique
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;



        public bool getBun()
        {
            return bun;
        }

        public void setBun(bool b)
        {
            bun = b;
            if (bun == false)
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




        public bool getTomato()
        {
            return tomato;
        }

        public void setTomato(bool b)
        {
            tomato = b;
            if (tomato == false)
            {
                specialInstructions.Add("Hold tomato");
            }
        }



        public bool getLettuce()
        {
            return lettuce;
        }

        public void setLettuce(bool b)
        {
            lettuce = b;
            if (lettuce == false)
            {
                specialInstructions.Add("Hold lettuce");
            }
        }



        public bool getMayo()
        {
            return mayo;
        }

        public void setMayo(bool b)
        {
            mayo = b;
            if (mayo == false)
            {
                specialInstructions.Add("Hold mayo");
            }
        }











    }
}
