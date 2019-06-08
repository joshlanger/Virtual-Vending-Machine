using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class VendingMachine
    {
        public static string MmmmGood { get; set; }
        public static decimal InitialBalance { get; set; }
        public static decimal CurrentBalance { get; set; }
        public static bool BoughtDrink { get; set; }
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

        public static void DispenseChange(decimal change, decimal fedMoney)
        {
            int quarters = 0;
            int dimes = 0;
            int nickle = 0;

            for (decimal i = fedMoney; i > 0.00M; i--)
            {
                if (fedMoney >= 0.25M)
                {
                    fedMoney = fedMoney - 0.25M;
                    quarters++;

                }
                if (fedMoney < 0.25M && fedMoney >= 0.10M)
                {
                    fedMoney = fedMoney - 0.10M;
                    dimes++;
                }
                if (fedMoney < 0.10M && fedMoney >= 0.05M)
                {
                    fedMoney = fedMoney - 0.05M;
                    nickle++;
                }
            }
            Console.WriteLine(quarters + " quarters, " + dimes + " dimes, and " + nickle + "nickles.");
        }  
        public static void MainMenu(string choice)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("(1) Display items");
            Console.WriteLine("(2) Purchase");
            choice = Console.ReadLine();
        }
        public static decimal PurchaseItem(string selectedProducted, decimal fedMoney)
        {
            if (vendMachine[selectedProducted].Count == 0)
            {
                Console.WriteLine("Item Sold Out");
                return fedMoney;
            }
            
            else
            {
                Item desiredItem = vendMachine[selectedProducted].Pop();
                string Name = desiredItem.Name;
                decimal Price = desiredItem.Price;
                if (fedMoney >= Price)
                {
                    InitialBalance = fedMoney;
                    fedMoney = fedMoney - Price;
                    Console.WriteLine(fedMoney);
                    return fedMoney;
                }
                if (fedMoney < Price)
                {
                    Console.WriteLine("Insufficient funds");
                    vendMachine[selectedProducted].Push(desiredItem);
                }
                if(vendMachine[selectedProducted].Count<5)
                {
                    MmmmGood += desiredItem.EatingSoundEffects();
                }
            }
            return fedMoney;
        }
    }
}
