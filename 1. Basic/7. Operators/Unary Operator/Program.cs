using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10, result;
            bool flag = true;

            result = +num;
            Console.WriteLine("+num = " + result);

            result = -num;
            Console.WriteLine("-num = " + result);

            result = ++num;
            Console.WriteLine("++num = " + result);

            result = --num;
            Console.WriteLine("--num = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.ReadLine();
        }
    }
}
 