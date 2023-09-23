using System;

namespace C__Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(5,10));  //Returns the highest value of x and y
            Console.WriteLine(Math.Min(5, 10)); //Returns the lowest value of x and y
            Console.WriteLine(Math.Sqrt(25));   //Returns the square root of x
            Console.WriteLine(Math.Abs(-10));   //Returns the absolute positive value of x
            Console.WriteLine(Math.Round(9.99));  //Rounds a number to the nearest whole number

            Console.ReadLine();
        }
    }
}
