using System;

namespace Method_Overriding_Example
{
    // Base class
    class Animal
    {
        // Virtual method that can be overridden in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        // Method overriding - Overriding the base class method
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        // Method overriding - Overriding the base class method
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the derived classes
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Calling the overridden methods to make sounds
            dog.MakeSound(); // Outputs: "Woof!"
            cat.MakeSound(); // Outputs: "Meow!"

            Console.ReadLine();
        }
    }
}
