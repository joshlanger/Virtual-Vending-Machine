﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /*Gum class inherits from base Item 
      and overides the EatingSoundEffects method. */
    public class Gum : Item
    {
        public Gum(string name, decimal price) : base(name, price) { }
        public override string EatingSoundEffects()
        {
            return "Chew Chew, Yum!";
        }
    }
}
