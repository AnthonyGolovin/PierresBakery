using System;
using System.Collections.Generic;
using Product.Bread;
using Product.Pastry;

namespace Bakery {
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("BAKERY PRODUCTS:");
            Console.WriteLine("Bread: $5 per piece.");
            Console.WriteLine("Pastry: $2 per pastry.");
            Console.WriteLine("Enter the amount of Bread and Pastries you would like in the following format (Bread Quanity. Pastry Quantity) EX.(5,9).");
                string userInput = Console.ReadLine();
                string[] cart = userInput.Split(",");
                int amountOfBread = int.Parse(cart[0]);
                int amountOfPastry = int.Parse(cart[1]);

                Bread bread = new Bread(amountOfBread);
                    Console.WriteLine("$" + bread.BreadTotal + " is the total for the Bread");

                Pastry pastry = new Pastry (amountOfPastry);
                     Console.WriteLine("$" + pastry.PastryTotal + " is the total for the Pastry");

                int totalTotal = bread.BreadTotal + pastry.PastryTotal;

                Console.WriteLine("Your total for today will be $"  + totalTotal);
        }
    }
}