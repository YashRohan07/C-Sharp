using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Public access modifier is accessible for all classes
namespace Public_Modifier
{
    class Car
    {
        public string model = "Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            Console.WriteLine(obj.model);
            Console.ReadLine();
        }
    }
}
