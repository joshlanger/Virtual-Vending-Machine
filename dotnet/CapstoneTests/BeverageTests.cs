using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class BeverageTest
    {
        [TestMethod]
        public void TestBeverageSounds()
        {
            Beverage TestBeverage = new Beverage("Cola", (decimal)1.60);
            Assert.AreEqual("Glug Glug, Yum!", TestBeverage.EatingSoundEffects());
        }
 
    }
}
