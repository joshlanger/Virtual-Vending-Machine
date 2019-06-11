using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone
{
    /*Beverage class inherits from base Item 
      and overides the EatingSoundEffects method. */
    public class Beverage : Item
    {
        public Beverage(string name, decimal price) : base(name, price) { }

        public override string EatingSoundEffects()
        {
            return "Glug Glug, Yum!";
        }

    }
}
