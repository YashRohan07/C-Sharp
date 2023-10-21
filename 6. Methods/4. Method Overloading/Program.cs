using System;

namespace MethodOverloadingExample
{
    //In Method overloading: Multiple methods can have the same name with different parameters
    class Program
    {
        // Method to add two integers
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to concatenate two strings
        static string Add(string a, string b)
        {
            return a + b;
        }

        // Method to display an integer and a string
        public void Display(int a, string b)
        {
            Console.WriteLine("Integer: " + a + " String: " + b);
        }

        // Method to display a string and an integer by changing the order of the above parameter
        public void Display(string a, int b)
        {
            Console.WriteLine("String: " + a + " Integer: " + b);
        }

        static void Main(string[] args)
        {
            // Using the overloaded Add methods
            Console.WriteLine("Sum of 5 and 10 is: " + Add(5, 10));
            Console.WriteLine("Sum of 5, 10, and 15 is: " + Add(5, 10, 15));
           
            Console.WriteLine(Add("Hello", " World"));

            // Creating an object of the Program class
            Program obj = new Program();

            // Using the overloaded Display methods
            obj.Display(10, "Yash");
            obj.Display("Rohan", 20);

            Console.ReadLine();

          
        }
    }
}
