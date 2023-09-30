using System;

namespace Sum_of_first_n_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5, sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i; // sum = sum + i;
            }

            Console.WriteLine("Sum of first " + n + " natural number is: " + sum);
            Console.ReadLine();
        }
    }
}
