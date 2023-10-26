using System;

// Base class
class Animal
{
    public Animal()
    {
        Console.Write("I am an animal. ");
    }

    public Animal(string sound) : this()
    {
        Console.Write("I make a " + sound + " sound. ");
    }
}

// Derived class
class Dog : Animal
{
    public Dog() : base("bark")
    {
        Console.Write("I am a dog. ");
    }

    public Dog(string name) : base("bark")
    {
        Console.Write("My name is " + name + ". ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        Console.WriteLine();  // I am an animal.

        Animal animal2 = new Animal("meow");
        Console.WriteLine();  // I am an animal. I make a meow sound.

        Dog dog1 = new Dog();
        Console.WriteLine();  // I am an animal. I make a bark sound. I am a dog.

        Dog dog2 = new Dog("Buddy");
        Console.WriteLine();  // I am an animal. I make a bark sound. My name is Buddy.

        Console.ReadLine();
    }
}
