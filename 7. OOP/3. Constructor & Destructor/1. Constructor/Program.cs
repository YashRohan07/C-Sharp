using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Car
    {
        public string model;  //Field

        public Car()  //Constructor
        {
            model = "Mustang";
        }
        static void Main(string[] args)
        {
            Car obj = new Car();
            Console.WriteLine(obj.model);
            Console.ReadLine();
        }
    }
}
