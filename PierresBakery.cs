using System;
using System.Collections.Generic;
using System.Threading;
using Product.Bread;
using Product.Pastry;

namespace Bakery {
    public class Program
    {
        public static void Main()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Bakery();
        }
        public static void Bakery()
            {
            Console.WriteLine("\nBAKERY PRODUCTS:");
            Console.WriteLine("Bread: $5 per piece.");
            Console.WriteLine("Pastry: $2 per pastry.");
            Console.WriteLine("\n\nEnter the amount of Bread and Pastries you would like in the following format (Bread Quanity. Pastry Quantity) EX.(5,9).\n");
                
                string userInput = Console.ReadLine();
                string[] cart = userInput.Split(",");
                try {
                int amountOfBread = int.Parse(cart[0]);
                int amountOfPastry = int.Parse(cart[1]);

                Bread bread = new Bread(amountOfBread);
                    Console.WriteLine("\n$" + bread.BreadTotal + " is the total for the Bread");

                Pastry pastry = new Pastry (amountOfPastry);
                     Console.WriteLine("$" + pastry.PastryTotal + " is the total for the Pastry");

                int totalTotal = bread.BreadTotal + pastry.PastryTotal;

                Console.WriteLine("\nYour total for today will be $"  + totalTotal + "\n");
                } catch (Exception error) //Exception is a data type for error handling and error is the name used if you wanna print it or something (Note to self)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nINVALID FORMAT, PLEASE USE NUMBERS AND CREATE YOU ORDER IN THE EXAMPLE FORMAT: EX.5,5\n");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    Bakery();

                }
            }
    }
}