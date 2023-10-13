using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        // Initialize the 1D array with the specified size
        int[] array = new int[size];

        //Take the inputs
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element for position {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        //Print the array
        Console.WriteLine("The 1D array is:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.ReadLine(); 
    }
}
