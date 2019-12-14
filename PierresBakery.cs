using System;
using System.Collections.Generic;
using System.Threading;
using Product;

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
            Console.WriteLine("Bread: $5 per piece (Buy 2 get 1 free!).");
            Console.WriteLine("Pastry: $2 per pastry (Buy 1 for $2 or 3 for $5).");
            Console.WriteLine("Donut: $4 per Donut. (1 free Donut for every 2 pieces of bread!");
            Console.WriteLine("\n\nEnter the amount of Bread and Pastries you would like in the following format (Bread Quanity, Pastry Quantity, Donut Quantity) EX.(5,9,2).\n");
                
                string userInput = Console.ReadLine();
                string[] cart = userInput.Split(",");
                try {
                int amountOfBread = int.Parse(cart[0]);
                int amountOfPastry = int.Parse(cart[1]);
                int amountOfDonut = int.Parse(cart[2]);

                Bread bread = new Bread(amountOfBread);
                    Console.WriteLine("\n$" + bread.BreadTotal + " is the total for the Bread");

                Pastry pastry = new Pastry (amountOfPastry);
                     Console.WriteLine("$" + pastry.PastryTotal + " is the total for the Pastries");

                Donut donut = new Donut (amountOfDonut, bread);
                     Console.WriteLine("$" + donut.DonutTotal + " is the total for the Donuts");

                int totalTotal = bread.BreadTotal + donut.DonutTotal;

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