//Multiple derived classes inherit from a single base class
using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// First derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

// Second derived class
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Eat(); // Accessing the method from the base class
        dog.Bark(); // Accessing the method from the first derived class

        cat.Eat(); // Accessing the method from the base class
        cat.Meow(); // Accessing the method from the second derived class

        Console.ReadLine();
    }
}
