using System;

namespace SealedExample
{
    // Base class
    class Animal
    {
        public void Display()
        {
            Console.WriteLine("I am an animal.");
        }
    }

    // Sealed class derived from Animal
    sealed class Dog : Animal
    {
        // Hiding the Display method of the base class using the new keyword
        public new void Display()
        {
            Console.WriteLine("I am a dog.");
        }
    }

    /*
    // This line will cause error because 'Husky' cannot inherit from sealed class 'Dog'
    class Husky : Dog 
    {
    }

    */

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Display();  // I am a dog

            Console.ReadLine();
        }
    }
}
