using System;

namespace ENUM
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday = 5,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            // Accessing the enum items with the dot syntax
            Console.WriteLine(WeekDays.Monday); //Monday
            Console.WriteLine(WeekDays.Tuesday); //Tuesday
            Console.WriteLine(WeekDays.Wednesday); //Wednesday
            Console.WriteLine(WeekDays.Thursday); //Thursday
            Console.WriteLine(WeekDays.Friday); //Friday
            Console.WriteLine(WeekDays.Saturday); //Saturday
            Console.WriteLine(WeekDays.Sunday); //Sunday

            Console.WriteLine("==========================");

            // Accessing the integer value
            Console.WriteLine((int)WeekDays.Monday); // Output: 0
            Console.WriteLine((int)WeekDays.Tuesday); // Output: 1
            Console.WriteLine((int)WeekDays.Wednesday); // Output: 5
            Console.WriteLine((int)WeekDays.Thursday); // Output: 6
            Console.WriteLine((int)WeekDays.Friday); // Output: 7
            Console.WriteLine((int)WeekDays.Saturday); // Output: 8
            Console.WriteLine((int)WeekDays.Sunday); // Output: 9

            Console.ReadLine();
        }
    }
}
