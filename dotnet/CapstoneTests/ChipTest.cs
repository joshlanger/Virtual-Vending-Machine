using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class ChipTest
    {
        [TestMethod]
        public void testChipSound()
        {
            //Arrange
            Chip chipSound = new Chip("Potato Crisps", 3.05M);
            //Assert
            Assert.AreEqual("Crunch Crunch, Yum!", chipSound.EatingSoundEffects());
        }
    }
}
