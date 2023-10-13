using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        Console.WriteLine("Enter the elements of the array:");

        //Take the inputs
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element for position [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //Print the array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
