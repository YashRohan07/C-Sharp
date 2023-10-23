using System;

namespace Inheritance
{
    // Base class
    class Animal
    {
        public string Name;
        public void Display()
        {
            Console.WriteLine("I am an animal");
        }
    }

    // Derived class of Animal
    class Dog : Animal
    {
        public void GetName()
        {
            Console.WriteLine("My name is: " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();

            obj.Name = "Piku";

            // Calling the Display method of the base class Animal
            obj.Display();

            // Calling the GetName method of the Dog class
            obj.GetName();

            Console.ReadLine();
        }
    }
}
