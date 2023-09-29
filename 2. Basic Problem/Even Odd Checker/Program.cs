using System;

namespace Even_Odd_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.ReadLine();
        }
    }
}
