using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Assignment_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            num += 5;  // num = num+5 = 10+5=15
            Console.WriteLine(num);

            num -= 3;  // num = num-3 = 15-3=12
            Console.WriteLine(num);

            num *= 2;  // num = num*2 = 12*2=24
            Console.WriteLine(num);

            num /= 3;  // num = num/3 = 24/3=8
            Console.WriteLine(num);

            num %= 3; // num = num%3 = 8%3=2
            Console.WriteLine(num);

            num &= 10; // num = num&10 = 2&10=2
            Console.WriteLine(num);

            num |= 14; // num = num|14 = 2|14 =14
            Console.WriteLine(num);

            num ^= 12; // num = num^12 = 14^12=2
            Console.WriteLine(num);

            num <<= 2;
            Console.WriteLine(num);

            num >>= 3;
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
