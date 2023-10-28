//base keyword is used to call the base class constructor,
//this keyword is used to call another constructor within the same class.

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

/*

Animal Class:
It has two constructors:
The first constructor Animal() doesn't take any parameters and it prints "I am an animal. "
The second constructor Animal(string sound) takes a sound parameter. Within this constructor, the this() keyword is used to call the first constructor Animal(),
ensuring that the "I am an animal. " message is printed first. Then, it prints "I make a [sound] sound. " where [sound] is the value of the sound parameter.


Dog Class: (The Dog class is derived from the Animal class)
It also has two constructors:
The first constructor Dog() doesn't take any parameters. It calls the base class constructor Animal(string sound) with the argument "bark" using the base keyword.
After that, it prints "I am a dog. "
The second constructor Dog(string name) takes a name parameter. It also calls the base class constructor Animal(string sound) with the argument "bark" using the base keyword.
Then, it prints "My name is [name]. " where [name] is the value of the name parameter.

*/
