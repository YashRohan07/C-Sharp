using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiple_Objects
{
    class Car
    {
        int year;
        string model;
        string color;
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.year = 1999;
            Ford.model = "Mustang";
            Ford.color = "Read";

            Car Audi = new Car();
            Audi.year = 1998;
            Audi.model = "Series-8";
            Audi.color = "Black";

            Console.WriteLine(Ford.model);
            Console.WriteLine(Audi.model);
            Console.ReadLine();
        }
    }
}
