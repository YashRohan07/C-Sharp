/* Write a program that takes a number as input and prints its multiplication table up to 10. */

using System;

namespace Lab_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table for {n}:");

            for (int i = 1; i <= 10; i++)
            {
                int product = n * i;
                Console.WriteLine($"{n} * {i} = {product}");
            }

            Console.ReadLine();
        }
    }
}
