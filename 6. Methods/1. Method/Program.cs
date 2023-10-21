using System;
using System.Collections.Generic;

namespace Method
{
    class Program
    {
        // Method declaration
        public void display() // Declaring a public method 
        {
            Console.WriteLine("Yash");
        }
        static void MyMethod() // Declaring a static method 
        {
            Console.WriteLine("Rohan");
        }

        public void Greet(string name) // Another public method 
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public static int Add(int a, int b) // Static method with a return type
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Create class object
            Program obj = new Program();

            // Calling the public method
            obj.display();  //Yash

            // Calling the static method
            MyMethod(); //Rohan
           
            // Calling the another public method
            obj.Greet("John");  //Hello, John!

            // Calling the static method 
            int result = Add(5, 3);
            Console.WriteLine($"Result: {result}");  // Result: 8

            Console.ReadLine();
        }
    }
}
