using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 30, num2 = 20, result;

            result = num1 + num2;
            Console.WriteLine("Addition: " + result);

            result = num1 - num2;
            Console.WriteLine("Subtraction: " + result);

            result = num1 * num2;
            Console.WriteLine("Multiplication: " + result);

            result = num1 / num2;
            Console.WriteLine("Division: " + result);

            result = num1 % num2;
            Console.WriteLine("Modulo: " + result);

            
            Console.ReadLine();
        }
    }
}
