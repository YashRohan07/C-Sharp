using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_With_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;

                if (i == 4)
                {
                    // If 'i' is equal to 4, break out of the while loop.
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}

/*
1
2
3
 */
