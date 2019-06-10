using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    class ReadInputFileTests
    {
        [TestMethod]
        public void CheckVendingMachineStocksCorrectly()
        {
            ReadInInputFile.InputInventory();
            
        }
    }
}
