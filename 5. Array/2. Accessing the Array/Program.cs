using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessing_the_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] car = {"BMW","AUDI","Toyota"};
            Console.WriteLine(car[0]); //Access the elements of the array

            Console.WriteLine("Array Size: " +car.Length); //Array Length

            car[0] = "Honda";  //Change the array elements
            Console.WriteLine(car[0]); //Outputs Honda insted of BMW

            Console.ReadLine();
        }
    }
}
