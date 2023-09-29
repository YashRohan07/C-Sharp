using System;

class Program
{
    static void Main()
    {
        int year;
        Console.Write("Enter a Year: ");
        year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not Leap Year");
        }

        Console.ReadLine();
    }
}
