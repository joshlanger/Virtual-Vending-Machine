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
                    bool exitToMainMenu = false;
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
                    }       
                    if (choice == "2")
                    {
                        
                        decimal fedMoney = 0;
                        do
                        {
                            Console.WriteLine("Purchase Menu");
                            Console.WriteLine("(1) Feed Money");
                            Console.WriteLine("(2) Select Product");
                            Console.WriteLine("(3) Finish Transaction");
                            Console.WriteLine("Current Money Provided: $" + fedMoney);
                            string selection = Console.ReadLine();
                            if (selection == "1")
                            {
                                Console.WriteLine("Please feed money in whole dollar amounts($1, $5, $10, or $20)");
                                Console.WriteLine("How much money do you want to feed?");
                                string fedMoneyString = Console.ReadLine();
                                if(fedMoneyString == "1" || fedMoneyString == "5" || fedMoneyString == "10" || fedMoneyString == "20")
                                {
                                    fedMoney += VendingMachine.FeedMoney(fedMoneyString);
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect denomination. The money fed must be in whole dollar amounts(ex. $1, $5, etc)");
                                    Console.WriteLine();
                                }
                            }                                                    
                            if (selection == "2")
                            {
                                VendingMachine.DisplayItems();
                                Console.WriteLine("Please type your selection(ex. A1)");
                                string selectedProduct = Console.ReadLine().ToUpper();
                                if (VendingMachine.vendMachine.ContainsKey(selectedProduct))
                                {
                                    fedMoney = VendingMachine.PurchaseItem(selectedProduct, fedMoney);
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect entry. Item does not exist!");
                                    Console.WriteLine();
                                }
                            }
                            if (selection == "3")
                            {
                                VendingMachine.DispenseChange(fedMoney);
                                Console.WriteLine("Are sure you want to finish you transaction? ");
                                string exitQuestion = Console.ReadLine().ToUpper();
                                if (exitQuestion == "N")
                                {
                                    exitToMainMenu = false;
                                }
                                if(exitQuestion == "Y")
                                {
                                    exitToMainMenu = true;
                                  
                                }
                                
                                fedMoney = 0;
                            }

                        }
                        while (!exitToMainMenu);

                    }
                   

                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
