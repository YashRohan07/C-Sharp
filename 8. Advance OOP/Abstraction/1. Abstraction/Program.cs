using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        //Non abstract method
        public void display1()
        {
            Console.WriteLine("Non abstract method");
        }

        //Abstract method
        public abstract void display2();
        
    }

    class Dog : Animal
    {
        //Implementing the abstract method from the base class
        public override void display2()
        {
            Console.WriteLine("Abstract method");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();

            // Accessing the non-abstract method from the base class
            obj.display1();  // Outputs: Non abstract method

            // Accessing the abstract method implemented in the derived class
            obj.display2();  // Outputs: Abstract method

            Console.ReadLine();
        }
    }
}
