using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Car
    {
        //We can not call a Static Constructor directly. 
        //When we call a regular constructor, the static constructor gets called automatically
        static Car()
        {
            Console.WriteLine("Static Constructor");
        }

        //Parameterless Constructor
        Car()
        {
            Console.WriteLine("Default Constructor");
        }
        static void Main(string[] args)
        {
            //Calling the parameterless constructor
            Car obj1 = new Car();
            Car obj2 = new Car();

            Console.ReadLine();
        }
    }
}

/*
Output:
Static Constructor
Default Constructor
Default Constructor

 */
