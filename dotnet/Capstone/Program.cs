using System;
using System.IO;
using System.Collections.Generic;
using Capstone.Classes;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadInInputFile.InputInventory();
            VendingMachine.PrintItems();
            
            Console.ReadLine();
        }
    }
}
