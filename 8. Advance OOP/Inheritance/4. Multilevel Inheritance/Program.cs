//A derived class inherits from a base class and then ....
//the same derived class acts as a base class for another class.
using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// Derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

// Derived class from Dog
class Kutta : Dog
{
    public void Play()
    {
        Console.WriteLine("Playing...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kutta obj = new Kutta();
        obj.Eat(); // Accessing the method from the base class
        obj.Bark(); // Accessing the method from the first derived class
        obj.Play(); // Accessing the method from the second derived class

        Console.ReadLine();
    }
}
