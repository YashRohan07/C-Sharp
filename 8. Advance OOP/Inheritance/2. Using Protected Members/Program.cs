using System;

namespace UsingProtectedMembers
{
    // Base class
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        protected void Display()
        {
            Console.WriteLine("I am an animal. My name is " + name + ".");
        }
    }

    // Derived class of Animal
    class Dog : Animal
    {
        // Constructor for Dog class
        public Dog(string name) : base(name)
        {
        }
        public void DisplayDog()
        {
            Console.WriteLine("My name is: " + name);
        }

        // Public method in the Dog class to access the protected Display method
        public void DisplayAnimal()
        {
            Display();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy");

            // Accessing the 'DisplayDogName' method of the Dog class
            dog.DisplayDog();

            // Accessing the 'DisplayAnimalInfo' method of the Dog class
            dog.DisplayAnimal();

            Console.ReadLine();
        }
    }
}


/*
using System;

namespace Inheritance
{
    //Base class
    class Animal
    {
        protected void eat()
        {
            Console.WriteLine("I can eat");
        }
    }

    //Derived class of Animal
    class Dog : Animal
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();

            obj.eat();
            Console.ReadLine();
        }
    }
}
*/