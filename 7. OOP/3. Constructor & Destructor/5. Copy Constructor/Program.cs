using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Car
    {
        string brand;

        //Constructor
        Car(string theBrand)
        {
            brand = theBrand;
        }

        //Copy Constructor
        Car(Car c1)
        {
            brand = c1.brand;
        }
        static void Main(string[] args)
        {
            //Call the Constructor
            Car obj1 = new Car("Mustang");
            Console.WriteLine("Brand of Car1: " +obj1.brand);

            //Call the copy constructor
            Car obj2 = new Car(obj1);
            Console.WriteLine("Brand of Car2: " + obj2.brand);

            Console.ReadLine();
        }
    }
}
