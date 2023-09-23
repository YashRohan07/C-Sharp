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
