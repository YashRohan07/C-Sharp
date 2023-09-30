using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Initializations___Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for( ; i<=5; )
            {
                Console.WriteLine("Iteration {0}", i);
                i++;

                Console.ReadLine();
            }
        }
    }
}

/*

Iteration 1

Iteration 2

Iteration 3

Iteration 4

Iteration 5


 */
