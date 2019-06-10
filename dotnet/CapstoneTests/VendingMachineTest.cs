using Capstone;
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
        public void FeedMoneyConvertToDecimalTest()
        {
            ////Act
            //decimal moneyFed = VendingMachine.FeedMoney("0.75");
            //decimal amountRequired = 1.00M;
            //bool fedMoney = ( amountRequired > moneyFed);
            //Assert
            //Assert.IsTrue(true, "Transaction canceled. You didn't enter a whole dollar amount.");
            Assert.AreEqual(.75M, VendingMachine.FeedMoney("0.75"));
            Assert.AreEqual(5, VendingMachine.FeedMoney("5"));
            Assert.AreEqual(-1, VendingMachine.FeedMoney("-1"));
        }
        [TestMethod]
        public void DispenseCorrectCoinsTest()
        {
            int quarters = 0;
            VendingMachine.DispenseChange(1M);
            Assert.AreEqual(4, quarters);
        }
        [TestMethod]
        public void PurchaseItemTest()
        {
           
            decimal fedMoney = 2.30M;
            Assert.AreEqual(.80M, VendingMachine.PurchaseItem("B3", fedMoney));
        }
        
    }
}
