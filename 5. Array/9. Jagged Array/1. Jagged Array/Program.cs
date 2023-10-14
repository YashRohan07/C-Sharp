using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            //Initialize while declaring
            int[][] arr =
            {
                new int[] {1,2,3}, //First array with 3 elements
                new int[] {4,5},  //Second array with 2 elements
            };

            */
             
            //Declare a jagged array
            int[][] arr = new int[2][];

            //Set the size of jagged array elements
            arr[0] = new int[3];
            arr[1] = new int[2];

            //Initialize the first array
            arr[0][0] = 1;
            arr[0][1] = 2;
            arr[0][2] = 3;

            //Initialize the second array
            arr[1][0] = 4;
            arr[1][1] = 5;


            /*
            Console.WriteLine( arr[0][1]); //2
            Console.WriteLine( arr[0][2]); //3
            Console.WriteLine( arr[1][1]); //5
            */


            /*
             
            // Outer Loop: To access the elements(array) of the jagged array
            for (int i = 0; i < arr.Length; i++)
            {
                // Inner Loop: To access the elements of the individual array inside the jagged array
               for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            */


            foreach (int[] item in arr)  //Iterate through each array in the jagged array
            {
                 foreach (int i in item)  //Iterate through each element in the inner array
                {
                     Console.Write(i + " ");
                 }
                 Console.WriteLine();
             }
            

            Console.ReadLine();
        }
    }
}
