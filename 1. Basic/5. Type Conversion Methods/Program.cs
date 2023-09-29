using System;

namespace Type_Conversion_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 5.25;
            bool c = true;
            char d = 'A';
            int e = 65;

            Console.WriteLine(Convert.ToString(a));       // Convert int to string
            Console.WriteLine(Convert.ToDouble(a));       // Convert int to double
            Console.WriteLine(Convert.ToInt32(b));        // Convert double to int
            Console.WriteLine(Convert.ToString(c));       // Convert bool to string
            Console.WriteLine(Convert.ToInt32(d));        // Convert char to int (ASCII value)
            Console.WriteLine(Convert.ToChar(e));         // Convert int (ASCII value) to char

            Console.ReadLine();
        }
    }
}
/*
Output:
10
10
5
True
65
A
*/
