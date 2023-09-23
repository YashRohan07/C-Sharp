using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Initializations___iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=0, j=0; i+j<=5; i++,j++)
            {
                Console.WriteLine("i = {0} and j = {1}", i,j);
                Console.ReadLine();
            }
        }
    }
}

/*
 
i = 0 and j = 0

i = 1 and j = 1

i = 2 and j = 2

 */
