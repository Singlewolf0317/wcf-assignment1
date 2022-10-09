using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string choice = "";
            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\tWCF Assignment 1");
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.Write("\t Enter your choice: ");
                choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter a integer: ");
                            int prime = int.Parse(Console.ReadLine());
                            Console.WriteLine(client.CheckPrime(prime));
                            break;
                        case "2":
                            Console.Write("Enter a integer: ");
                            int digit = int.Parse(Console.ReadLine());
                            Console.WriteLine(client.SumDigits(digit));
                            break;
                        case "3":
                            Console.Write("Enter a string: ");
                            Console.WriteLine(client.ReverseString(Console.ReadLine()));
                            break;
                        case "4":
                            Console.Write("Enter a tag: ");
                            string tag = Console.ReadLine();
                            Console.Write("Enter a data: ");
                            string data = (Console.ReadLine());
                            Console.WriteLine(client.PrintHTMLTag(tag, data));
                            break;
                        case "5":
                            Console.Write("Enter a sort type (Ascending or Descending): ");
                            string sort = Console.ReadLine();
                            Console.Write("Enter a list of integer: ");
                            string intArray = Console.ReadLine();
                            Console.WriteLine(client.SortNumbers(sort, intArray));
                            break;
                        default:
                            Console.WriteLine("--Please enter a valid choice.--\n");
                            break;
                    }
                    Console.WriteLine("\n");
                }
                catch
                {
                    Console.WriteLine("--Please enter a valid input.--\n");
                }
                
            }
        }
    }
}
