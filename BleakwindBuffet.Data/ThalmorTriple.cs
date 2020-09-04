using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: ThalmorTriple.cs
     * Purpose: To track Thalmor Triple burgers: Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
     */
    public class ThalmorTriple
    {
        //standard

        private double price = 8.32;
        private uint calories = 943;
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
            return "Thalmor Triple";
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
        private bool bacon = true;
        private bool egg = true;



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



        public bool getBacon()
        {
            return bacon;
        }

        public void setBacon(bool b)
        {
            bacon = b;
            if (bacon == false)
            {
                specialInstructions.Add("Hold bacon");
            }
        }

        public bool getEgg()
        {
            return egg;
        }

        public void setEgg(bool b)
        {
            egg = b;
            if (egg == false)
            {
                specialInstructions.Add("Hold egg");
            }
        }










    }
}
