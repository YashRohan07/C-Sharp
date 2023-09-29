/* Write a program that ask the users to type 5 integers and write the average of that 5
 integers. But this program can use only 2 variables....*/
using System;

namespace Lab_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter 5 integers:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter integer {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());

                // Add the entered number to the sum
                sum += num;
            }

            double average = (double)sum / 5;

            Console.WriteLine($"The average of the 5 integers is: {average}");

            Console.ReadLine();
        }
    }
}
