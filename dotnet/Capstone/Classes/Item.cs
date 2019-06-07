using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone
{
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
