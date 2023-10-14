using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a jagged array
            int[][] arr = new int[2][];

            // Set the size of jagged array elements based on user input
            Console.WriteLine("Enter the size of the first array: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            arr[0] = new int[size1];

            Console.WriteLine("Enter the size of the second array: ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            arr[1] = new int[size2];


            // Initialize the elements of the first array based on user input
            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine($"Enter element {i + 1} of the first array: ");
                arr[0][i] = Convert.ToInt32(Console.ReadLine());
            }

            // Initialize the elements of the second array based on user input
            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine($"Enter element {i + 1} of the second array: ");
                arr[1][i] = Convert.ToInt32(Console.ReadLine());
            }

           
            foreach (int[] item in arr) // Iterate through each array in the jagged array
            {
                foreach (int i in item) // Iterate through each element in the inner array
                {
                    Console.Write(i + " "); 
                }
                Console.WriteLine(); 
            }

            Console.ReadLine();
        }
    }
}
