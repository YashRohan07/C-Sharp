using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise___Bit_shift_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20, result;

            result = ~num1;
            Console.WriteLine(result);

            result = num1 & num2;
            Console.WriteLine(result);

            result = num1 | num2;
            Console.WriteLine(result);

            result = num1 ^ num2;
            Console.WriteLine(result);

            result = num1 << 2;
            Console.WriteLine(result);

            result = num1 >> 2;
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
