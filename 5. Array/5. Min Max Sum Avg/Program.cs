using System;
using System.Linq;  //This namespace is used for those methods

namespace Min_Max_Sum_Avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1, 2, 3, 4, 5};
            Console.WriteLine("Maximum Number: " +num.Max());
            Console.WriteLine("Minimum Number: " + num.Min());
            Console.WriteLine("Sum: " + num.Sum());
            Console.WriteLine("Total Number: " + num.Count());
            Console.WriteLine("Average: " + num.Sum()/num.Count());

            Console.ReadLine();
        }
    }
}
