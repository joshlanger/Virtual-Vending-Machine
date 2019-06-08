using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class LogSales
    {

        public static void LogPurchases(string fedMoney, decimal price, string change)
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
    }
}
