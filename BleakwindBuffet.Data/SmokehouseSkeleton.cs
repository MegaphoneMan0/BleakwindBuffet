using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: SmokehouseSkeleton.cs
     * Purpose: To track Smokehouse Skeleton: Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
     */
    public class SmokehouseSkeleton
    {


        //special instructions
        private List<String> specialInstructions;


        public List<String> getSpecialInstructions()
        {
            return specialInstructions;
        }














        //properties



        //standard

        private double price = 5.62;
        private uint calories = 602;

        public double getPrice()
        {
            return price;
        }

        public uint getCalories()
        {
            return calories;
        }

        


        //unique

        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;



        public bool getSausageLink()
        {
            return sausageLink;
        }

        public void setSausageLink(bool b)
        {
            sausageLink = b;
            if (sausageLink == false)
            {
                specialInstructions.Add("Hold sausage link");
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

        public bool getHashBrowns()
        {
            return hashBrowns;
        }

        public void setHashBrowns(bool b)
        {
            hashBrowns = b;
            if (hashBrowns == false)
            {
                specialInstructions.Add("Hold hash browns");
            }
        }


        public bool getPancake()
        {
            return pancake;
        }

        public void setPancake(bool b)
        {
            pancake = b;
            if (pancake == false)
            {
                specialInstructions.Add("Hold pancakes");
            }
        }

















        //tostring

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }






    }
}
