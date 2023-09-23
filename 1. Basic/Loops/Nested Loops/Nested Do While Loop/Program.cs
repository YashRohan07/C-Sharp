using System;

namespace Nested_Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                int j = 0;
                do
                {
                    Console.Write("({0},{1}) ", i, j); // Added a space
                    j++;
                }
                while (j < 2);
                i++;
                Console.WriteLine(); // Moved this line outside the inner do-while loop
            }
            while (i < 2); // Removed the extra semicolon

            Console.ReadLine(); // Moved this line outside the outer do-while loop
        }
    }
}

/*
 
(0,0) (0,1)
(1,0) (1,1)

 */
