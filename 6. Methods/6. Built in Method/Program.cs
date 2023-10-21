using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Sqrt(9);
            Console.WriteLine("Square root of 9 is: " + a);

            // Absolute value of a number
            int b = Math.Abs(-10);
            Console.WriteLine("Absolute value of -10 is: " + b);

            // Random number between 0 and 1
            double random = new Random().NextDouble();
            Console.WriteLine("Random number between 0 and 1: " + random);

            // Minimum of two numbers
            int min = Math.Min(5, 3);
            Console.WriteLine("Minimum of 5 and 3 is: " + min);

            // Maximum of two numbers
            int max = Math.Max(7, 12);
            Console.WriteLine("Maximum of 7 and 12 is: " + max);

            // Rounding a number to the nearest integer
            double c = Math.Round(6.7);
            Console.WriteLine("Rounded value of 6.7 is: " + c);

            // Getting the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current date and time is: " + now);

            Console.ReadLine();
        }
    }
}
