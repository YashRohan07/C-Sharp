using System;

namespace Constructor_Chaining
{
    class Test
    {
        Test(int num1, int num2)
        {
            Console.WriteLine("Constructor with two parameters");
        }

        // Constructor with one parameter, which calls the two-parameter constructor using "this(22,33)"
        Test(int num) : this(22, 33)
        {
            Console.WriteLine("Constructor with one parameter");
        }

        static void Main(string[] args)
        {
            // Creating an instance of the Test class with a single integer argument
            Test obj = new Test(5);
            Console.ReadLine();
        }
    }
}

/*
 
Output:
Constructor with two parameters
Constructor with one parameter

 */

/*
It uses constructor chaining to call the two-parameter constructor using this(22, 33). 
This means that when an instance of this constructor is created,
it first invokes the two-parameter constructor with values 22 and 33 before executing its own code.
 */
