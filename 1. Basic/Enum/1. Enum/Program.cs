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
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Saturday);
            Console.WriteLine(WeekDays.Sunday);

            Console.WriteLine("==========================");

            // Accessing the integer value
            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Wednesday);
            Console.WriteLine((int)WeekDays.Thursday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Saturday);
            Console.WriteLine((int)WeekDays.Sunday);

            Console.ReadLine();
        }
    }
}
