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
            //string directory = @"C:\Users\Joshua Langer\capstone1\c-module-1-capstone-team-6\dotnet\etc";
            string directory = Environment.CurrentDirectory;
            // string directory = @"C:\Users\Chad Campbell\Capstone\c - module - 1 - capstone - team - 6\dotnet\etc";
            string filename = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, filename);

            
            
            try
            {
                using(StreamReader sr = new StreamReader(fullPath, false))
                {
                    while (!sr.EndOfStream)
                    {
                        // Read in a single line and 
                        string line = sr.ReadLine();
                        string[] input = line.Split("|");
                        string slot = input[0];
                        string name = input[1];
                        decimal price = decimal.Parse(input[2]);
                        string itemType = input[3];
                       

                        Stack<Item> SlotStack = new Stack<Item>();
                        for (int i = 0; i < 5; i++)
                        {
                            if (itemType == "Drink")
                            {
                                SlotStack.Push(new Beverage(name, price));
                                
                            }
                            if (itemType == "Chip")
                            {
                                SlotStack.Push(new Chip(name, price));
                                
                            }
                            if(itemType == "Gum")
                            {
                                SlotStack.Push(new Gum(name, price));
                                
                            }
                            if(itemType == "Candy")
                            {
                                SlotStack.Push(new Candy(name, price));
                                
                            }
                            
                        }
                        
                        VendingMachine.vendMachine.Add(slot, SlotStack);

                    }

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
