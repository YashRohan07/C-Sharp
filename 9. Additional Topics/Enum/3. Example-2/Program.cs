using System;

namespace EnumExample
{
    enum WeekDays
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday,     // 4
        Saturday,   // 5
        Sunday      // 6
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using the enum to declare a variable
            WeekDays today = WeekDays.Tuesday;

            switch (today)
            {
                case WeekDays.Monday:
                case WeekDays.Tuesday:
                case WeekDays.Wednesday:
                case WeekDays.Thursday:
                case WeekDays.Friday:
                    Console.WriteLine("It's a weekday.");
                    break;

                case WeekDays.Saturday:
                case WeekDays.Sunday:
                    Console.WriteLine("It's the weekend!");
                    break;

                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }

            Console.ReadLine();

            /*
             The switch statement is used to perform different actions based on the value of the today variable.
             If the value matches any of the cases for Monday to Friday, it prints "It's a weekday." 
             If the value matches Saturday or Sunday, it prints "It's the weekend!". 
             If the value doesn't match any of the defined cases, it prints "Invalid day."
             */
        }
    }
}
