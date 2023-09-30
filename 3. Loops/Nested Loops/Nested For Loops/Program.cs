using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outerLoop = 0, innerLoop = 0;
            for(int i=1; i<=5; i++)
            {
                outerLoop++;
                for(int j=1; j<=5; j++)
                {
                    innerLoop++;
                }
            }
            // the outer loop runs 5 times, and for each iteration of the outer loop, the inner loop runs 5 times,
            // resulting in a total of 25 iterations for the inner loop.
            Console.WriteLine("Outer Loop runs {0} times", outerLoop);
            Console.WriteLine("Inner Loop runs {0} times", innerLoop);

            Console.ReadLine();
        }
    }
}

/*
 
Outer Loop runs 5 times
Inner Loop runs 25 times

 */
