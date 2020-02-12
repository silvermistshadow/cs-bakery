using System;

namespace Bakery
{
    class Program
    {
        public static void Main()
        {
            int numPastries;
            int numBread;
            Console.WriteLine($"Welcome to Pierre's Bakery. Bread is {Bread.Price} normally, but if you buy 2, you get one free. Pastries are {Pastry.Price} for 1, or 3 for $5.");
            Console.WriteLine("How many loaves of bread would you like?");
            try 
            {
                numBread = Int32.Parse(Console.ReadLine());

            }
            catch(FormatException) 
            {
                Console.WriteLine("Please enter a whole number, no letters.");
                numBread = Int32.Parse(Console.ReadLine());
            }
            finally 
            {   Console.WriteLine("How many pastries would you like?");
                try 
                {
                numPastries = Int32.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                Console.WriteLine("Please enter a whole number, no letters.");
                numPastries = Int32.Parse(Console.ReadLine());
                }
            }

            Order.addTotal(numBread, numPastries);

            Console.WriteLine($"Your total is ${Order.Total}");

        }
    }
}