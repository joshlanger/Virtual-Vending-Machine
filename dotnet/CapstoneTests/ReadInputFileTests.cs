using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class ReadInputFileTests
    {
        [TestMethod]
        public void CheckVendingMachineStocksCorrectly()
        {
            ReadInInputFile.InputInventory();
            Item TestItem = VendingMachine.vendMachine["A1"].Pop();
            Assert.AreEqual("Potato Crisps", TestItem.Name);
            Assert.AreEqual(3.05M, TestItem.Price);
            Assert.AreEqual(5, VendingMachine.vendMachine["A2"].Count);
        }
    }
}
