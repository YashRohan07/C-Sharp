using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Private access modifier can only accessed within the same class or struct.
namespace Private_Modifier
{
    class Car
    {
        private string model = "Series-8";

        string brand = "BMW";  //By default all members of a class are private,
                               //if you don't specify an access modifier.

        static void Main(string[] args)
        {
            Car obj = new Car();
            Console.WriteLine(obj.model);
            Console.WriteLine(obj.brand);
            Console.ReadLine();
        }
    }
}
