using System;

namespace JaggedArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            // Creating a jagged array with multidimensional array elements
            int[][,] jaggedArray = new int[][,]
            {
                new int[,] { {1, 2, 3}, {4, 5, 6} },
                new int[,] { {7, 8, 2}, {9, 10, 11} },
                new int[,] { {13, 14, 15}, {16, 17, 18} }
            };

            */

            // Creating a jagged array without specifying the sizes of sub-arrays during initialization
            int[][][] jaggedArray = new int[][][]
            {
                new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 }
                },
                new int[][]
                {
                    new int[] { 7, 8 },
                    new int[] { 9, 10, 11, 12 }
                },
                new int[][]
                {
                    new int[] { 13, 14, 15 },
                    new int[] { 16, 17 }
                }
            };


            // Iterating through the jagged array and printing its elements using for loops
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Array " + i + ":"); // Output the current array index

                // Loop through the first dimension of the current sub-array
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    // Loop through the second dimension of the current sub-array
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        Console.Write(jaggedArray[i][j][k] + " "); // Output each element in the sub-array
                    }
                    Console.WriteLine(); // Move to the next line after printing all elements in the current row
                }
                Console.WriteLine(); // Print an empty line to separate the arrays visually
            }


            /*

            foreach (var subArray in jaggedArray)
            {
                Console.WriteLine($"Array {Array.IndexOf(jaggedArray, subArray)}:");

                foreach (var innerArray in subArray)
                {
                    foreach (var element in innerArray)
                    {
                        Console.Write(element + " "); // Output each element in the sub-array
                    }
                    Console.WriteLine(); // Move to the next line after printing all elements in the current row
                }
                Console.WriteLine(); // Print an empty line to separate the arrays visually
            }

            */

            Console.ReadLine();
        }
    }
}
