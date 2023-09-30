using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Outer Loop
            for(int i=1; i<=2; i++)
            {
                Console.WriteLine("Outer: " +i);

                // Inner Loop
                for(int j=1; j<=3; j++)
                {
                    Console.WriteLine("Inner: " +j);
                }

                Console.ReadLine();

            }
        }
    }
}

/*

Outer: 1
Inner: 1
Inner: 2
Inner: 3
 

 */