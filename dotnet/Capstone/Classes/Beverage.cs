using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone
{
    public class Beverage : Item
    {
        public Beverage(string name, decimal price) : base(name, price) { }

        public override string EatingSoundEffects()
        {
            return "Glug Glug, Yum!";
        }

    }
}
