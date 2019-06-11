using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    /*ReadInInputFile class uses StreamReader to read in the VendingMaching
     * inventory and instatiates a new SlotStack which pushes inventory 
     * to the SlotStack by ItemType (Chips, Gum, etc.). 
     * Finally, SlotStack is added to the VendingMachine dictionary by calling
     * VendingMachine.VendMachine.Add().
     */
    public static class ReadInInputFile
    {
        
       public static void InputInventory()
        {
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, filename);

            try
            {   //Reads in vending machine inventory.
                using (StreamReader sr = new StreamReader(fullPath, false))
                {
                    while (!sr.EndOfStream)
                    {
                        
                        string line = sr.ReadLine();
                        string[] input = line.Split("|");
                        string slot = input[0];
                        string name = input[1];
                        decimal price = decimal.Parse(input[2]);
                        string itemType = input[3];


                        //Instatiates a new SlotStack which pushes inventory 
                        //to the SlotStack by ItemType(Chips, Gum, etc.).
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
                        /*SlotStack is added to the VendingMachine dictionary 
                         * by calling VendingMachine.VendMachine.Add().*/
                        VendingMachine.vendMachine.Add(slot, SlotStack);

                    }

                }
            }
            /*Throws execption message if user attempts to 
             * use an invalid file or directory, 
            and writes "Invalid File or Directory."*/
            catch(IOException e)
            {
                Console.WriteLine("Invalid File or Direcory.");
                Console.WriteLine(e.Message);

            }
        }

    }
}
