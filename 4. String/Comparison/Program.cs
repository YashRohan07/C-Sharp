using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Java";
            string y = "Java";
            string z = "Python";

            Boolean result1 = x.Equals(y);
            Console.WriteLine("x and y are equal: " +result1);   //x and y are equal: True

            Boolean result2 = x.Equals(z);
            Console.WriteLine("x and z are equal: " +result2);   //x and z are equal: False

            Console.ReadLine();
               

        }
    }
}
