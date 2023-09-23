using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_with_Nested_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (j == 2)
                    {
                        continue;
                    }

                    Console.WriteLine("i = " + i + " j = " + j);
                }
            }

            Console.ReadLine();
        }
    }
}

/*
Output:
i = 1 j = 1
i = 1 j = 3
i = 2 j = 1
i = 2 j = 3
i = 3 j = 1
i = 3 j = 3
*/
