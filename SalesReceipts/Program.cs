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
                int ID = ConfirmIntInput("Invalid answer, pls enter a valid value");
                Console.WriteLine("Enter the number of cogs");
                reply = Console.ReadLine();
                int cogs;

                Console.WriteLine("Enter the number of gears");
                reply = Console.ReadLine();
                int gears;

                Console.WriteLine("Enter the customer ID");
                reply = Console.ReadLine();
                

                Console.WriteLine("Do you want to input another receipt? Yeah/Nah");
                reply = Console.ReadLine();

            } while (reply == "Yeah");
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstMsg"></param>
        /// <param name="reMsg"></param>
        /// <returns></returns>
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
