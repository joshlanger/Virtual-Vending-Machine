using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone
{
    public class Item
    {
       protected string Name { get; set; }
       protected decimal Price { get; set; }
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
