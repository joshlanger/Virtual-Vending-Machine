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
        public void BeverageSound()
        {
            //Arrange
            Beverage beverageSound = new Beverage("Cola", 1.25M);
            //Assert
            Assert.AreEqual("Glug Glug, Yum!", beverageSound.EatingSoundEffects());
        }
    }
}
