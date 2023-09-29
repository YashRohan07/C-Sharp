/* Write a program to convert days to years,weeks and days...*/

using System;

namespace Lab_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {days}");

            Console.ReadLine();
        }
    }
}

