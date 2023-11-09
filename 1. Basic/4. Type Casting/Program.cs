using System;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting
            int x = 5;
            double y = x;  // Automatic casting: int to double
            
            Console.WriteLine(x);  // Output: 5
            Console.WriteLine(y);  // Output: 5

            Console.WriteLine();

            // Explicit Casting
            double a = 5.5;
            int b = (int)a;  // Manual casting: double to int

            Console.WriteLine(a);  // Output: 5.5
            Console.WriteLine(b);  // Output: 5

            Console.WriteLine();

            // Conversion between incompatible types
            string stringValue = "123";
            int convertedInt = Convert.ToInt32(stringValue);  // Converting string to int
            
            Console.WriteLine("String value: " + stringValue);  // String value: 123
            Console.WriteLine("Converted integer value: " + convertedInt);  // Converted integer value: 123

            Console.WriteLine();

            // Conversion between incompatible types
            string stringValue2 = "789";
            bool convertedBool = Convert.ToBoolean(stringValue2);  // Converting string to boolean
            
            Console.WriteLine("String value: " + stringValue2);  // Output: String value: 789
            Console.WriteLine("Converted boolean value: " + convertedBool);  // Output: Converted boolean value: True

            Console.ReadLine();
        }
    }
}

/*
Implicit Casting:
an int value x is implicitly converted to a double value y. Implicit casting is done automatically by the compiler, 
as converting from a smaller data type (int) to a larger data type (double) doesn't lead to any loss of data.

Explicit Casting:
a double value a is explicitly converted to an int value b using the (int) cast. Explicit casting is performed manually by the programmer,
as converting from a larger data type (double) to a smaller data type (int) may lead to a loss of data. The explicit cast discards the fractional part of the double value.
*/
