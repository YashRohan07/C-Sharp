using System;

namespace Class_Object_Updated
{
    class Cat
    {
        public int age;
        public string name;
        public string color;

        // Default constructor with default values
        public Cat()
        {
            age = 10;
            name = "Peu";
            color = "Brown";
        }

        // Parameterized constructor to set cat information
        public Cat(int age, string name, string color)
        {
            this.age = age;
            this.name = name;
            this.color = color;
        }

        // Destructor (not commonly used in C#)
        ~Cat()
        {
            Console.WriteLine("Destructor...");
        }

        public void run()
        {
            Console.WriteLine("Running...");
        }

        public void sleep()
        {
            Console.WriteLine("Sleeping...");
        }

        public void getInfo()
        {
            Console.WriteLine("Cat is {0} and its name is {1} and age is {2}", color, name, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a cat object using the default constructor
            Cat c1 = new Cat();
            c1.age = 6;
            c1.name = "Perrry";
            c1.color = "Black";

            // Display cat information using different methods
            Console.WriteLine("Cat is " + c1.color + " and its name is " + c1.name + " and age is " + c1.age);
            Console.WriteLine("Cat is {0} and its name is {1} and age is {2}", c1.color, c1.name, c1.age);

            c1.run();
            c1.sleep();
            c1.getInfo();  //Cat is Black and its name is Perrry and age is 6


            // Create another cat object using the default constructor
            Cat c2 = new Cat();
            c2.getInfo();   //Cat is Brown and its name is Peu and age is 10


            // Create a cat object using the parameterized constructor
            Cat c3 = new Cat(9, "Wooly", "White");
            c3.getInfo();  //Cat is White and its name is Wooly and age is 9

            Console.ReadLine();
        }
    }
}
