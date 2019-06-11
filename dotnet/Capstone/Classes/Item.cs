using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone
{
    /*Item class is the base class that sets the Name and Price properties.
     * In addition, it contains the Item contructor and 
     * the vitural EatingSoundEffects method overriden
     * by the Beverage, Candy, Gum, and Chips classes. */
    public class Item
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
       
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
            

        }
        public virtual string EatingSoundEffects()
        {
            return "";
        }

    }
}
