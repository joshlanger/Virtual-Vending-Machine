using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class VendingMachine
    {
        public static decimal Balance { get; set; }
        public static Dictionary<string, Stack<Item>> vendMachine = new Dictionary<string, Stack<Item>>();
        public static void PrintItems()
        {
            Console.WriteLine("Slot".PadRight(6) + "Item".PadRight(20) + " Price".PadRight(10) + " Quantity");
            foreach (KeyValuePair<string, Stack<Item>> kvp in vendMachine)
            {
                Item foo = kvp.Value.Pop();
                Console.WriteLine($"{kvp.Key.PadRight(5)} {foo.Name.PadRight(20)} {foo.Price} \t{kvp.Value.Count + 1}");
                kvp.Value.Push(foo);
                
            }

        }
        
        public static decimal FeedMoney(string fedMoneyString)
        {
            decimal fedMoney = decimal.Parse(fedMoneyString);
            return fedMoney;
        }
        public static void MainMenu(string choice)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("(1) Display items");
            Console.WriteLine("(2) Purchase");
            choice = Console.ReadLine();
        }
        public static void PurchaseItem(string selectedProducted, decimal fedMoney)
        {
            if (vendMachine[selectedProducted].Count == 0)
            {
                Console.WriteLine("Item Sold Out");
            }
            else
            {
                Item boughtItem = vendMachine[selectedProducted].Pop();
                string Name = boughtItem.Name;
                decimal Price = boughtItem.Price;
                if (fedMoney >= Price)
                {
                    decimal change = fedMoney - Price;
                    Balance = change;
                }
            }
            
        }
    }
}
