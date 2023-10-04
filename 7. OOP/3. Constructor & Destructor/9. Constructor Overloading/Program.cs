using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Car
    {
        //Constructor with no parameter
        Car()
        {
            Console.WriteLine("Car Constructor");
        }

        //Constructor with one parameter
        Car(string brand)
        {
            Console.WriteLine("Brand: " +brand);
        }
        static void Main(string[] args)
        {
            //Calling the Constructor with no parameter
            Car obj1 = new Car();
            Console.WriteLine();

            //Calling the Constructor with parameter
            Car obj2 = new Car("Bugatti");
            Console.ReadLine();

        }
    }
}

/*
 
Output:
Car Constructor
Brand: Bugatti

 */
