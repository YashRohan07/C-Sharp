using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 5, b = 6;

            if (a>b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a<b)
            {
                Console.WriteLine("b is greater than a");
            }
            else
            {
                Console.WriteLine("a is equal to b");
            }

            Console.ReadLine();

            */


            //Using ternary operator...
            int a = 10; 
            int b = 5;  

            string result = a > b ? "a is greater than b" : a < b ? "b is greater than a" : "a is equal to b";

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
