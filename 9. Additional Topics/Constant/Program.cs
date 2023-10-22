using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            //const keyword is used to declare variables whose values cannot be changed once they are assigned,
            //and they must be initialized at the time of declaration.
            const double pi = 3.1416;

            Console.Write("Enter Radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = pi * radius * radius;
            Console.WriteLine("Area is  : " + area);

            Console.ReadLine();
        }
    }
}
