using System;

namespace Base_Keyword
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Animal Class");
        }
    }

    class Dog : Animal
    {
        // Overridden method that calls the base class method
        public override void eat()
        {
            // Calling the base class method using base keyword
            base.eat();

            Console.WriteLine("Dog Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Dog class
            Dog obj = new Dog();

            // Calling the overridden method
            obj.eat();
            Console.ReadLine();

            /*
            Animal Class
            Dog Class
            */
        }
    }
}
