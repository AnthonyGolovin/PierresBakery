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
            int userInput = int.Parse(Console.ReadLine());
            int[] cart = userInput.Split(",");

            Console.WriteLine("");
        }
    }
}