using System;

namespace Abstraction
{
    // Abstract class providing a blueprint for Animal
    abstract class Animal
    {
        // Non-abstract method
        public void Display1()
        {
            Console.WriteLine("Non abstract method");
        }

        // Abstract method to be implemented by derived classes
        public abstract void Display2();

        // Virtual method with a default implementation
        public virtual void Display3()
        {
            Console.WriteLine("Virtual method");
        }
    }

    class Dog : Animal
    {
        // Implementing the abstract method from the base class
        public override void Display2()
        {
            Console.WriteLine("Abstract method");
        }

        // Overriding the virtual method from the base class
        public override void Display3()
        {
            Console.WriteLine("Updated virtual method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            // Accessing the non-abstract method from the base class
            dog.Display1(); // Outputs: Non abstract method

            // Accessing the abstract method implemented in the derived class
            dog.Display2(); // Outputs: Abstract method

            // Accessing the overridden virtual method from the derived class
            dog.Display3(); // Outputs: Updated virtual method

            Console.ReadLine();
        }
    }
}
