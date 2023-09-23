using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<2)
            {
                int j = 0;
                while(j<2)
                {
                    Console.WriteLine("({0},{1})", i,j);
                    j++;
                }
                i++;
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

/*
 
(0,0)
(0,1)

*/
