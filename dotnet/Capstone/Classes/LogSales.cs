using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class LogSales
    {

        public static void LogPurchases(decimal fedMoney, string selectedProduct, string name, decimal price)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "Log.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string date = DateTime.Now.ToString();
                    string fedMoneyString = fedMoney.ToString();
                    decimal balance = fedMoney - price;
                    string balanceString = balance.ToString();
                    if(!fedMoneyString.Contains("."))
                    {
                        fedMoneyString = fedMoneyString + ".00";
                    }
                    if(!balanceString.Contains("."))
                    {
                        balanceString = balanceString + ".00";
                    }
                    sw.WriteLine($"{date} {name.PadRight(15)} {selectedProduct}  ${fedMoneyString.PadRight(10)}  ${balanceString.PadRight(10)}");
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Out of Order! Please Add more money!");
                Console.WriteLine(e.Message);
            }
            
        }
        public static void FedMoneyLog(string fedMoney)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "Log.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                string feedMoney = "FEED MONEY:";
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string date = DateTime.Now.ToString();
                    fedMoney = fedMoney + ".00";                   
                    sw.WriteLine($"{date} {feedMoney.PadRight(19)} ${fedMoney.PadRight(10)}  ${fedMoney.PadRight(10)}" );
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Out of Order! Please Add more money!");
                Console.WriteLine(e.Message);
            }

        }
        public static void ReturnMoneyLog(string fedMoneyString)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "Log.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string date = DateTime.Now.ToString();
                    string giveChange = "GIVE CHANGE:";
                    if (!fedMoneyString.Contains("."))
                    {
                        fedMoneyString = fedMoneyString + ".00";
                    }
                    string zero = "0.00";
                    sw.WriteLine($"{date} {giveChange.PadRight(19)} ${fedMoneyString.PadRight(10)}  ${zero.PadRight(10)}" );
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Out of Order! Please Add more money!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
