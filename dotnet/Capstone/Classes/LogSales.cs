using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class LogSales
    {
        public static void LogPurchases()
        {
            string directory = Environment.CurrentDirectory;
            string filename = "Log.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string date = DateTime.Now.ToString();
                    decimal moneyFed = fedMoney;
                    decimal purchases = price;
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
