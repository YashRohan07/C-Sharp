using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_with_multiple_parameter
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        //Constructor with multiple parameter
        public Car(string modelName, string modelColor, int modelYear)  
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car obj = new Car("Mustang", "Black", 1999); //passing the values to the constructor
            Console.WriteLine(obj.model);
            Console.WriteLine(obj.color);
            Console.WriteLine(obj.year);
            Console.ReadLine();
        }
    }
}
