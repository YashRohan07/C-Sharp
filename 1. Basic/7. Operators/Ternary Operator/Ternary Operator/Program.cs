using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            string result;

            // Variable = condition? Expression1 : Expression2
            result = (num % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

/*
result = (num % 2 == 0) ? "Even Number" : "Odd Number"; - It consists of three parts:

1. (num % 2 == 0) is the condition. It checks whether the remainder of "num" divided by 2 is equal to 0, which determines whether the number is even.
2.  ? "Even Number" is the expression to be executed if the condition is true.
3.  : "Odd Number" is the expression to be executed if the condition is false.

*/
