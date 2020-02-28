using System;

namespace Bakery
{
    class Program
    {
        public static void Main()
        {
            try
            {
                int numPastries;
                int numBread;
                Console.WriteLine($"Welcome to Pierre's Bakery. Bread is ${Bread.Price} normally, but if you buy 2, you get one free. Pastries are ${Pastry.Price} for 1, or 3 for $5.");
                Console.WriteLine("How many loaves of bread would you like?");
                numBread = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How many pastries would you like?");
                numPastries = Int32.Parse(Console.ReadLine());
                Order.addTotal(numBread, numPastries);
                Console.WriteLine($"Your total is ${Order.Total}");
            }
            catch(FormatException)
            {
                Console.WriteLine("I TOLD YOU TO ENTER NUMBERS!");
            }

        }
    }
}