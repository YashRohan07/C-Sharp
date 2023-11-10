using System;

namespace UsingProtectedMembers
{
    // Base class
    class Animal
    {
        protected string name;  //name field
        public Animal(string name)
        {
            this.name = name;  //this.name refers to the name field of the current Animal object, while name is the parameter passed to the constructor. 
                               //This usage is used to differentiate between the name field of the class and the parameter with the same name.
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
           //Dog class doesn't have its own constructor but uses the base constructor to set the name
           //base(name) is used to call the constructor of the base class Animal with the parameter name
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

            // Accessing the 'DisplayAnimal' method of the Dog class
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
