using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_With_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            { 
                if (i == 3)
                {
                    // If 'i' is equal to 3, break out of the loop.
                    break;
                }

                // This line will only be executed if 'i' is not equal to 3.
                // However, it doesn't contain any code to execute, so it prints an empty line.
                Console.WriteLine();
            }

            
            Console.ReadLine();
        }
    }
}
