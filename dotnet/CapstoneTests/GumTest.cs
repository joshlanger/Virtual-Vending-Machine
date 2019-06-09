using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class GumTest
    {
        [TestMethod]
        public void TestCandySound()
        {
            //Arrange
            Gum gumSound = new Gum("Chiclets", 0.75M);
            //Assert
            Assert.AreEqual("Chew Chew, Yum!", gumSound.EatingSoundEffects());
        }
    }
}
