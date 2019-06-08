using System;
using System.IO;
using System.Collections.Generic;
using Capstone.Classes;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                bool isComplete = false;
                while (!isComplete)
                {
                    string choice = "";
                    ReadInInputFile.InputInventory();
                    Console.WriteLine("Welcome to the Vend-Matic 500!");
                    Console.WriteLine();
                    Console.WriteLine("Please see our menu options below.");
                    Console.WriteLine("(1) Display items");
                    Console.WriteLine("(2) Purchase");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        
                        VendingMachine.DisplayItems();
                        Console.WriteLine("Please press(2) to make a purchase: ");
                        choice = Console.ReadLine();
                        //VendingMachine.MainMenu(choice);
                        //choice = Console.ReadLine();
                            
                        
                    

                    }
                      //} while (choice != "1");
                    
                    if (choice == "2")
                    {
                        
                        decimal fedMoney = 0;
                        while (!isComplete)
                        { 
                            Console.WriteLine("Purchase Menu");
                            Console.WriteLine("(1) Feed Money");
                            Console.WriteLine("(2) Select Product");
                            Console.WriteLine("(3) Finish Transaction");
                            Console.WriteLine("Current Money Provided: $" + fedMoney);
                            string selection = Console.ReadLine();
                            if (selection == "1")
                            {
                                Console.WriteLine("Please feed money in whole dollar amounts(ex. $1, $5, etc)");
                                Console.WriteLine("How much money do you want to feed?");
                                string fedMoneyString = Console.ReadLine();
                                fedMoney += VendingMachine.FeedMoney(fedMoneyString);

                            }

                            if (selection == "2")
                            {
                                VendingMachine.DisplayItems();
                                Console.WriteLine("Please type your selection(ex. A1)");
                                string selectedProduct = Console.ReadLine();
                                if(VendingMachine.vendMachine.ContainsKey(selectedProduct))
                                {
                                    fedMoney = VendingMachine.PurchaseItem(selectedProduct, fedMoney);
                                    
                                }

                            }
                            if (selection == "3")
                            {
                                VendingMachine.DispenseChange(VendingMachine.Change, fedMoney);
                                //isComplete = true;
                                fedMoney = 0;
                            }

                        }

                    }
                    //ReadInInputFile.InputInventory();
                    //Console.WriteLine("Welcome to the Vend-Matic 500!");
                    //Console.WriteLine();
                    //Console.WriteLine("Please see our menu options below.");
                    //Console.WriteLine("(1) Display items");
                    //Console.WriteLine("(2) Purchase");
                    //choice = Console.ReadLine();

                    Console.ReadLine();
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
