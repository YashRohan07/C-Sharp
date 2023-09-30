using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_for_loop_to_print_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j + " ");
                }

                //The pattern starts with 1 on the first line, then on each subsequent line,
                //it adds one more number, incrementing from 1 up to the current line number.
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

/*
 
1

1 2

1 2 3

1 2 3 4

1 2 3 4 5

 */
