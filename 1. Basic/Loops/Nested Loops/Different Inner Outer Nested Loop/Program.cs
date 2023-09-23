using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Inner_Outer_Nested_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                // Start a nested for loop with variable 'j' initialized to 1, running while 'j' is less than or equal to 'i'.
                for (int j = 1; j <= i; j++)
                {
                    // Print the current value of 'i' followed by a space.
                    Console.Write(i + " ");
                }

                // Move to the next line after printing the numbers in the row.
                Console.WriteLine();

                // Increment 'i' to prepare for the next row.
                i++;

               
                Console.ReadLine();
            }
        }
    }
}

/* Output:
1

2 2

3 3 3

4 4 4 4

5 5 5 5 5
*/
