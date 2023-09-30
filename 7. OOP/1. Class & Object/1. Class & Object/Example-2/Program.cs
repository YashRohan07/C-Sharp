using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Dog
    {
        public string breed; //Field
        public void bark() //Method
        {
            Console.WriteLine("Bark!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Dog class
            Dog myObj = new Dog();

            myObj.breed = "Bull Dog!!";
            Console.WriteLine(myObj.breed);

            myObj.bark(); // Call the "bark" method 

            Console.ReadLine();
        }
    }
}
