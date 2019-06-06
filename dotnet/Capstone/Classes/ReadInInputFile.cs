using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public static class ReadInInputFile
    {
       public static void InputInventory()
        {
            //string directory = Environment.CurrentDirectory;
            string directory = @"C:\Users\Chad Campbell\Capstone\c - module - 1 - capstone - team - 6\dotnet\etc";
            string filename = "vendingmachine.txt";
            string fullPath = Path.Combine(directory, filename);

            string slot = "";
            string name = "";
            string price = "";
            string itemType = "";
            try
            {
                using(StreamReader sr = new StreamReader(fullPath, false))
                {
                    while (!sr.EndOfStream)
                    {
                        // Read in a single line and 
                        string line = sr.ReadLine();
                        string[] input = line.Split("|");
                        
                 


                    } //go to the next line until the end is reached
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Invalid File or Direcory.");
                Console.WriteLine(e.Message);

            }
        }

    }
}
