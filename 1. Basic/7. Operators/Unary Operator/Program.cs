using System;

namespace Unary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10, result;
            bool flag = true;

            result = +num; // Unary plus doesn't change the value
            Console.WriteLine("+num = " + result); // Output: +num = 10

            result = -num; // Negation changes the sign of the value
            Console.WriteLine("-num = " + result); // Output: -num = -10

            result = ++num; // Pre-increment operator increments the value before the variable is used in an expression
            Console.WriteLine("++num = " + result); // Output: ++num = 11

            result = num++; // Post-increment operator increments the value after the variable is used in an expression
            Console.WriteLine("num++ = " + result); // Output: num++ = 11

            result = --num; // Pre-decrement operator decrements the value before the variable is used in an expression
            Console.WriteLine("--num = " + result); // Output: --num = 11

            result = num--; // Post-decrement operator decrements the value after the variable is used in an expression
            Console.WriteLine("num-- = " + result); // Output: num-- = 11

            Console.WriteLine("!flag = " + (!flag)); // Logical NOT operator negates the boolean value
            // Output: !flag = False

            Console.ReadLine();
        }
    }
}
