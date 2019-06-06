using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class VendingMachine
    {
        public static Dictionary<string, Stack<Item>> vendMachine = new Dictionary<string, Stack<Item>>();
        public static void PrintItems( )
        {
            foreach (KeyValuePair<string, Stack<Item>> kvp in vendMachine)
            {
                Console.WriteLine($"{kvp.Key} + {kvp.Value.Peek()}");
                
            }
        }
    }
}
