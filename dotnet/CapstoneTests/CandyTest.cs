using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class CandyTest
    {
        
        [TestMethod]
        public void TestCandySound()
        {
            //Arrange
            Candy candySound = new Candy("Wonka Bar", 1.50M);
            //Assert
            Assert.AreEqual("Munch Munch, Yum!", candySound.EatingSoundEffects());
        }
    }
}
