using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] number = { {1,2,3},{4,5,6} };
            int[,] number = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; //Declaring the number of rows and coloumns during initialization

            Console.WriteLine(number[0, 2]);  //Output: 3 
            Console.WriteLine(number[1, 2]); //Output: 6

            number[0, 0] = 8;  //Changing the value of an element
            Console.WriteLine(number[0, 0]);  //Output: 8

            Console.WriteLine(number.GetLength(0)); // Output:2 (Return Row) 
            Console.WriteLine(number.GetLength(1)); // Output:3 (Return Column)
            Console.WriteLine(number.Rank);// Output:2 (Returns diamension of the array)

            int columns = number.GetLength(1); //This retrieves the length of the second dimension..(the number of columns)
            Console.WriteLine(columns);  //Output: 3, as there are 3 columns in the array.

            /*
            The first dimension represents the number of rows,
            the second dimension represents the number of columns.
            The GetLength(1) method specifically targets the length of the second dimension.
            */

            Console.WriteLine("==================================================");

            for (int i = 0; i < number.GetLength(0); i++) //Outer for loop for rows
            {
                for (int j = 0; j < number.GetLength(1); j++) //Inner for loop for columns
                {
                    Console.Write(number[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
