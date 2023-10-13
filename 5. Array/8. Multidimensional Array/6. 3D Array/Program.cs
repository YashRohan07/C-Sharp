using System;

class Program
{
    static void Main()
    {
        int[,,] Array = new int[,,]
        {
            { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, // First 2D array
            { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } } // Second 2D array
        };

        for (int i = 0; i < 2; i++) // First dimension
        {
            for (int j = 0; j < 3; j++) // Second dimension
            {
                for (int k = 0; k < 3; k++) // Third dimension
                {
                    Console.Write(Array[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
/*
for (int i = 0; i < 2; i++): This for loop iterates over the first dimension of the 3D array. In this case, there are 2 2D arrays in the 3D array.
for (int j = 0; j < 3; j++): This for loop iterates over the second dimension of the 3D array. There are 3 rows in each 2D array.
for (int k = 0; k < 3; k++): This for loop iterates over the third dimension of the 3D array. There are 3 columns in each 2D array.


Output:
1 2 3
4 5 6
7 8 9

10 11 12
13 14 15
16 17 18

 */
