using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_of_Constructor
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string colorName, int modelYear)
        {
            model = modelName;
            color = colorName;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car obj1 = new Car("Audi", "Black", 1999);
            Car obj2 = new Car("BMW", "Red", 1995);

            Console.WriteLine(obj1.model);
            Console.WriteLine(obj2.model);
            Console.ReadLine();
        }

        /*
         //Without Constructor
        static void Main(string[] args)
        {
          Car obj1 = new Car();
          obj1.model = "Audi";
          obj1.color = "Black";

          Car obj2 = new Car();
          obj2.model = "BMW";
          obj2.color = "Red";

          Console.WriteLine(obj1.model);
          Console.WriteLine(obj2.model);
          Console.ReadLine();
        }
        */
    }
}
