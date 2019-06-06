using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone
{
    public class Beverage : Item
    {
        public Beverage(string name, decimal price) : base(name, price) { }
        
        Stack<int> ColaStack = new Stack<int>();
        
    }
}
