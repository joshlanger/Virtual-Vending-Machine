using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{   /*VendingMachine class instatiates our VendMachine dictionary
      holds our DisplayItems, FeedMOney, DispenseChange, and PurchaseItem ethods.
        */
    public static class VendingMachine
    {
        public static Dictionary<string, Stack<Item>> vendMachine = new Dictionary<string, Stack<Item>>();
        //Display VendingMachine items as long as the item Count does not equal zero.
        public static void DisplayItems()
        {
            Console.WriteLine("Slot".PadRight(6) + "Item".PadRight(20) + " Price".PadRight(10) + " Quantity");
            foreach (KeyValuePair<string, Stack<Item>> kvp in vendMachine)
            {
                if (kvp.Value.Count == 0)
                {
                    Console.WriteLine($"{kvp.Key.PadRight(5)} SOLD OUT");
                }
                else
                {
                    Item foo = kvp.Value.Pop();
                    Console.WriteLine($"{kvp.Key.PadRight(5)} {foo.Name.PadRight(20)} ${foo.Price} \t{kvp.Value.Count + 1}");
                    kvp.Value.Push(foo);
                }
                
            }

        }

        internal static decimal FeedMoney()
        {
            throw new NotImplementedException();
        }
        //Captures money fed and logs the money fed 
        //using LogSales.FedMoneyLog
        public static decimal FeedMoney(string fedMoneyString)
        {
            decimal fedMoney = decimal.Parse(fedMoneyString);
            LogSales.FedMoneyLog(fedMoneyString);
            Console.WriteLine("You have added $" + fedMoney);
            return fedMoney;
        }
        //Uses fedMoney to dispense change when user finishes
        //there purchase and calls logSales.ReturnMoneyLog to log purchases.
        public static void DispenseChange(decimal fedMoney)
        {
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            string fedMoneyString = fedMoney.ToString();
            Console.WriteLine("Dispensing change ($" + fedMoney +")");
            LogSales.ReturnMoneyLog(fedMoneyString);
            while (fedMoney != 0)
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
                    nickles++;
                }
                
            }
            if (quarters > 0)
            {
                Console.WriteLine(quarters + " quarter(s)");
            }
            if (dimes > 0)
            {
                Console.WriteLine(dimes + " dime(s)");
            }
            if (nickles > 0)
            {
                Console.WriteLine(nickles + " nickle(s)");
            }
        }    
        //PurchaseItem first checks that the item is not sold out.
        //If item is not sold out pops item off stack and logs purchage if
        //fedMoney is greater than price of item and writes LogSale LogPurchase.
        public static decimal PurchaseItem(string selectedProducted, decimal fedMoney)
        {   //PurchaseItem first checks that the item is not sold out.
            if (vendMachine[selectedProducted].Count == 0)
            {
                Console.WriteLine("Item Sold Out");
                Console.WriteLine();
                return fedMoney;
            }
            //If item is not sold out pops item off stack 
            else
            {
                Item desiredItem = vendMachine[selectedProducted].Pop();
                string name = desiredItem.Name;
                decimal price = desiredItem.Price;
                //fedMoney is greater than price of item and writes LogSale LogPurchase.
                if (fedMoney >= price)
                {
                    LogSales.LogPurchases(fedMoney, selectedProducted, name, price);
                    fedMoney = fedMoney - price;
                    Console.WriteLine($"{desiredItem.Name} ${desiredItem.Price}");
                    Console.WriteLine($"Current balance remaining: ${fedMoney}");
                    Console.WriteLine(desiredItem.EatingSoundEffects());
                    Console.WriteLine();
                   
                    return fedMoney;
                }
                //If fedMoney is less than price of item prints "Insufficient funds!"
                //pushes item back on the stack.
                if (fedMoney < price)
                {
                    Console.WriteLine("Insufficient funds!");
                    Console.WriteLine();
                    vendMachine[selectedProducted].Push(desiredItem);
                }
                
            }
            return fedMoney;
        }
    }
}
