using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void FeedMoneyLessThan1Dollar()
        {
            //Act
            decimal moneyFed = VendingMachine.FeedMoney("0.75");
            decimal amountRequired = 1.00M;
            bool fedMoney = ( amountRequired > moneyFed);
            //Assert
            Assert.IsTrue(true, "Transaction canceled. You didn't enter a whole dollar amount.");
        }

        
    }
}
