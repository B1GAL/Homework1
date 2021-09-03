using System;
using System.Collections.Generic;

namespace SalesReceipts
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<Receipt>> receipts = new Dictionary<int, List<Receipt>>();
            string reply;



            do
            {
                int ID = ConfirmIntInput("Enter customer's ID", "Invalid answer, pls enter a valid value");
                int cogs = ConfirmIntInput("Enter # of cogs", "Invalid answer, pls enter a valid value");
                int gears = ConfirmIntInput("Enter # of gears", "Invalid answer, pls enter a valid value");

                Receipt receipt = new Receipt(ID, cogs, gears);

                if (receipts.ContainsKey(ID))
                {
                    receipts[ID].Add(receipt);
                }
                else
                {
                    receipts.Add(ID, new List<Receipt>());
                }
                Console.WriteLine("Do you want to input another receipt? Yeah/Nah");
                reply = Console.ReadLine();

            } while (reply == "Yeah");
            
        }
        private static void DisplayOptions()
        {
            Console.WriteLine("".PadRight(15, '#')); //();
            Console.WriteLine("\tOptions");
            Console.WriteLine("1.) By customer ID");
            Console.WriteLine("2.) All of today's receipts");
            Console.WriteLine("3.) Receipt with highest total");
            Console.WriteLine("".PadRight(15, '#'));
            
        }
        private static int ConfirmIntInput(string firstMsg, string reMsg)
        {
            int value;
            string input;
            Console.WriteLine(firstMsg);
            
            input = Console.ReadLine();
            while (int.TryParse(input, out value) == false)
            {
                Console.WriteLine(reMsg);
                input = Console.ReadLine();

            }
            return value;
        }
    }
}
