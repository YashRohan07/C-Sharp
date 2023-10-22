using System;

namespace VAR
{
    class Program
    {
        static void Main(string[] args)
        {
            // int value
            var age = 45;
            Console.WriteLine("Var can hold int values: " + age);

            // float value
            var pi = 3.1416;
            Console.WriteLine("Var can hold floating point values: " + pi);

            // string value
            var name = "Yash Rohan";
            Console.WriteLine("Var can hold string values: " + name);

            // boolean value
            var isCorrect = true;
            Console.WriteLine("Var can hold boolean values: " + isCorrect);

            // Array
            var odds = new[] { 1, 3, 5, 7, 9 };
            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }

            for (var x = 1; x <= 5; x++)
            {
                Console.WriteLine("Allah");
            }


            // Valid and invalid var declarations...

            var message = "Hello, World!"; // Valid
            // var number;  // Invalid without an initialization
            // var result = null;  // Invalid for null initialization

            var p = 10; //Valid
            // var q; // Invalid without initialization
            // q = 10;
            // var r = null; // Invalid for null initialization

            Console.ReadLine();
        }
    }
}
