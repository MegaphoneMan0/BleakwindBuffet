using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
     * Author: John Solomon
     * Class name: GardenOrcOmelette.cs
     * Purpose: To track Garden Orc Omelette: Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
     */
    class GardenOrcOmelette
    {

        //standard

        private double price = 4.57;
        private uint calories = 404;
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
            return "Garden Orc Omelette";
        }



        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        public bool getBroccoli()
        {
            return broccoli;
        }

        public void setBroccoli(bool b)
        {
            broccoli = b;
            if (broccoli == false)
            {
                specialInstructions.Add("Hold broccoli");
            }
        }



        public bool getMushrooms()
        {
            return mushrooms;
        }

        public void setMushrooms(bool b)
        {
            mushrooms = b;
            if (mushrooms == false)
            {
                specialInstructions.Add("Hold mushrooms");
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


        public bool getCheddar()
        {
            return cheddar;
        }

        public void setCheddar(bool b)
        {
            cheddar = b;
            if (cheddar == false)
            {
                specialInstructions.Add("Hold cheddar");
            }
        }





    }
}
