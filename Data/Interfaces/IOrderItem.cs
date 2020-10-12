using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace BleakwindBuffet.Data.Interfaces
{
    public interface IOrderItem
    {

        double Price { get; }
    

        uint Calories { get; }

        List<string> SpecialInstructions { get; }

        void setIngredients(BindingList<string> vs);

    }
}
