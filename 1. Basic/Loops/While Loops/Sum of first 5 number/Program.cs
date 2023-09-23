using System;

namespace Sum_of_first_5_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0; // Declare the 'sum' variable and initialize it to 0

            while (i <= 5)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();
        }
    }
}
