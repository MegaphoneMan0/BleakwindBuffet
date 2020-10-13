using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;
using System.Net;
using System.Linq;

namespace BleakwindBuffet.Data
{


    class Combo : IOrderItem
    {

        private IOrderItem Entree;
        private IOrderItem Drink;
        private IOrderItem Side;


        public double Price { get; }

        public uint Calories { get; }

        public void setIngredients(BindingList<string> vs) 
        { 
            
        }

        public List<string> SpecialInstructions { get; }




        Combo(IOrderItem Entree,IOrderItem Drink, IOrderItem Side)
        {
            this.Entree = Entree;
            this.Drink = Drink;
            this.Side = Side;


            List<string> esp = new List<string>();
            esp.Add(Entree.GetType().Name);
            esp.Concat(Entree.SpecialInstructions);

            List<string> dsp = new List<string>();
            esp.Add(Drink.GetType().Name);
            esp.Concat(Drink.SpecialInstructions);

            List<string> ssp = new List<string>();
            esp.Add(Side.GetType().Name);
            esp.Concat(Side.SpecialInstructions);



            List<string> realSI = new List<string>();

            realSI.Concat(esp);
            realSI.Concat(dsp);
            realSI.Concat(ssp);



        }







        public List<string> SpecialInstructionsCombine() 
        {
            List<string> vs = new List<string>();





            return vs;        
        }




    }
}
