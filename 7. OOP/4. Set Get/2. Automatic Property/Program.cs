using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Property
{
    class Person
    {
        public string Name // Automatic Property
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person(); 

            obj.Name = "Yash"; 

            Console.WriteLine(obj.Name); // Display the value of the Name property
            Console.ReadLine();
        }
    }
}
