using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterless_Constructor
{
    class Car
    {
        Car()  //Parameterless Constructor
        {
            Console.WriteLine("Car Constructor");
        }
        static void Main(string[] args)
        {
            new Car();  //Calling the constructor
            Console.ReadLine();
        }
    }
}
