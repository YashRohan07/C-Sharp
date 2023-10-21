using System;

namespace Key_Value_Syntax
{
    internal class Program
    {
        static void Method(string child1, string child2, string child3)
        {
            Console.WriteLine("Youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            // Using key-value syntax to pass arguments to the Method
            Method(child3: "Yash", child2: "Rohan", child1: "Raina");

            // The order of the arguments can be changed without affecting the outcome
            Method(child2: "Rohan", child1: "Raina", child3: "Yash");

            // However, incorrect key names would result in compilation errors
            // Method(child_3: "Yash", child_2: "Rohan", child_1: "Raina");

            Console.ReadLine();
        }
    }
}
