using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;
            bool result;

            //OR operator (If one of the operand is true, OR operator returns true)
            result = (num1 == num2) || (num1 > 5);
            Console.WriteLine(result);  //True

            //AND operator  (If one of the operand is false, AND operator returns false)
            result = (num1 == num2) && (num1 > 5);
            Console.WriteLine(result);  //False

            Console.ReadLine();
        }
    }
}
