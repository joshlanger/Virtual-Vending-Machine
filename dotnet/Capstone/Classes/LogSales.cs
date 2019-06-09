using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class LogSales
    {

        public static void LogPurchases(decimal fedMoney, decimal price, string name)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "Log.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string date = DateTime.Now.ToString();
                    string slot = "";
                    string itemName = ""; 
                    decimal moneyFed = 0;
                    decimal purchases = 0;
                    sw.WriteLine( date + "$"+moneyFed +"$"+ purchases);
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
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string date = DateTime.Now.ToString();
                    fedMoney = fedMoney + ".00";                   
                    sw.WriteLine($"{date} FEED MONEY: ${fedMoney.PadRight(10)}  ${fedMoney.PadRight(10)}" );
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
                    if (!fedMoneyString.Contains("."))
                    {
                        fedMoneyString = fedMoneyString + ".00";
                    }
                    string zero = "0.00";
                    sw.WriteLine($"{date} GIVE CHANGE: ${fedMoneyString.PadRight(10)}  ${zero.PadRight(10)}" );
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
