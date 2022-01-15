using System;
using System.Collections.Generic;

namespace ListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for an operation (
            // a = Add a number to a running list (ask the user for the number).
            // r = Remove a number from the list (ask the user for the number).
            // q = Show the total of all numbers, and quit.
            //)
            // Keep asking until the user decides to quit.

            List<int> allNumbers = new List<int>();

            bool shouldContinue = true;

            do
            {
                Console.WriteLine("What do you want to do (a/r/q)?");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "a":
                        {
                            Console.WriteLine("Enter a number:");
                            string input = Console.ReadLine();
                            int num = int.Parse(input);
                            allNumbers.Add(num);
                            break;
                        }
                    case "r":
                        {
                            Console.WriteLine("Enter a number:");
                            string input = Console.ReadLine();
                            int num = int.Parse(input);
                            allNumbers.Remove(num);
                            break;
                        }
                    case "q":
                        {
                            shouldContinue = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }

            } while (shouldContinue);

            int sum = 0;
            foreach(int item in allNumbers)
            {
                sum += item;
            }

            Console.WriteLine("Your total is:");
            Console.WriteLine(sum);


        }
    }
}
