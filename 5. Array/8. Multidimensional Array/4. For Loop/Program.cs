using System;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] number = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("Elements in row 0:");
            for (int i = 0; i < number.GetLength(1); i++)  //number. GetLength(1) retrieves the length of the second dimension of the array.
            {
                Console.Write(number[0, i] + " ");  // 1 2 3
            }
            Console.WriteLine();

            Console.WriteLine("Elements in row 1:");
            for (int i = 0; i < number.GetLength(1); i++)
            {
                Console.Write(number[1, i] + " ");  // 4 5 6
            }
            Console.WriteLine();

            /*
            for(int i = 0; i<number.GetLength(0); i++)
            {
                for(int j = 0; j<number.GetLength(1); j++)
                {
                    Console.WriteLine(number[i,j]);
                }
             }
             */

            Console.ReadLine();
        }
    }
}
