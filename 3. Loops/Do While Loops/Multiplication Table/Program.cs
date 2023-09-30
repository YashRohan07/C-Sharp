using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n = 5, product;

            do
            {
                product = n * i;
                Console.WriteLine("{0} * {1} = {2}", n, i, product);
                i++;
                Console.ReadLine();
            }

            while (i <= 10);
            
        }
    }
}

/*
 * 
5 * 1 = 5

5 * 2 = 10

5 * 3 = 15

5 * 4 = 20

5 * 5 = 25

5 * 6 = 30

5 * 7 = 35

5 * 8 = 40

5 * 9 = 45

5 * 10 = 50


 */
