using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /*Candy class inherits from base Item 
      and overides the EatingSoundEffects method. */
    public class Candy : Item
    {
        public Candy(string name, decimal price) : base(name, price) { }
        public override string EatingSoundEffects()
        {
            return "Munch Munch, Yum!";
        }
    }
}
