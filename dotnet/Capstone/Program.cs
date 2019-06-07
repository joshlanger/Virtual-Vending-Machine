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
                ReadInInputFile.InputInventory();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1) Display items");
                Console.WriteLine("(2) Purchase");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    VendingMachine.PrintItems();
                   
                }
               if(choice == "2")
                {
                    decimal fedMoney = 0;
                    Console.WriteLine("Purchase Menu");
                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");
                    Console.WriteLine("Current Money Provided: $" + fedMoney);
                    string selection = Console.ReadLine();
                    if(selection == "1")
                    {
                        Console.WriteLine("Please feed money in whole dollar amounts(ex. $1, $5, etc)");
                        Console.WriteLine("How much money do you want to feed?");
                        string fedMoneyString = Console.ReadLine();
                        fedMoney += VendingMachine.FeedMoney(fedMoneyString);
                        
                    }
                    if(selection == "2")
                    {

                    }
                    if(selection == "3")
                    {

                    }
                    
                    
                }
                Console.ReadLine();
            }
            catch(Exception)
            {

            }

        }
    }
}
