using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    abstract class Entree
    {

        public abstract double Price();
        public abstract uint Calories();
        public abstract List<string> SpecialInstructions();




    }
}
