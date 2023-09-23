using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Casting
            int x = 5;
            double y = x;  // Automatic casting: int to double

            Console.WriteLine(x);  //Output:5
            Console.WriteLine(y);  //Output:5


            //Explicit Casting
            double a = 5.5;
            int b = (int)a;  // Manual casting: double to int

            Console.WriteLine(a);  //Output:5.5
            Console.WriteLine(b);  //Output:5


            Console.ReadLine();

        }
    }
}
