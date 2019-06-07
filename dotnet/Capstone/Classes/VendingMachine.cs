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
                Item foo = kvp.Value.Pop();
                Console.WriteLine($"{kvp.Key}  {foo.Name} {foo.Price}");
                kvp.Value.Push(foo);
                //{ kvp.Value.Peek()}
            }
        }
    }
}
