using System;

namespace C__Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(5, 10));  // Returns the highest value of x and y.  Output: 10
            Console.WriteLine(Math.Min(5, 10)); // Returns the lowest value of x and y.  Output: 5
            Console.WriteLine(Math.Sqrt(25));   // Returns the square root of x.  Output: 5
            Console.WriteLine(Math.Abs(-10));   // Returns the absolute positive value of x.  Output: 10
            Console.WriteLine(Math.Round(9.99));  // Rounds a number to the nearest whole number.  Output: 10
            Console.WriteLine(Math.Pow(2, 3)); // Returns the value of the first argument raised to the power of the second argument.  Output: 8

            Console.ReadLine();
        }
    }
}
