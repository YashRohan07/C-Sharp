using System;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine(); // Console.ReadLine() reads a line of text (string)
            Console.WriteLine("UserName is " + name);

            Console.Write("Press any key to continue...");
            Console.ReadKey();  //This is used to pause the program until the user press a key.
            Console.WriteLine();

            Console.Write("Enter a single character: ");
            int userInput = Console.Read(); // Console.Read() reads a single character and returns its ASCII value as an integer
            Console.WriteLine("Ascii value: " + userInput);

        }
    }
}
