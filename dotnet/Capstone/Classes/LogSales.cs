using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{   /* LogSale class uses StreamWriter within the LogPurchases method 
    to write the logFile */
    public static class LogSales
    {

        public static void LogPurchases(decimal fedMoney, string selectedProduct, string name, decimal price)
        {
            /*sets directory to the environments current directory, 
              sets filename, and combines path*/
            string directory = Environment.CurrentDirectory;
            string filename = "Log.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {   /*Writes log file using StreamWriter.
                  Writes each line of log file using sw.WriteLine (date,
                  name, selectedProduct, fedMoneyString, and balanceString*/
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
            /*Throws excepition message if user attempts to purchase 
              an Item before feeding enough money*/
            catch(IOException e)
            {
                Console.WriteLine("Out of Order! Please Add more money!");
                Console.WriteLine(e.Message);
            }
            
        }
        /*Uses StreamWriter to caputer "FeedMoneyString" of the log file.*/
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
            /*Throws excepition message if user attempts to purchase 
              an Item before feeding enough money*/
            catch (IOException e)
            {
                Console.WriteLine("Out of Order! Please Add more money!");
                Console.WriteLine(e.Message);
            }

        }
        /*Uses StreamWriter to caputer "giveChangeString" of the log file.*/
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
            /*Throws excepition message if user attempts to purchase 
              an Item before feeding enough money*/
            catch (IOException e)
            {
                Console.WriteLine("Out of Order! Please Add more money!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
