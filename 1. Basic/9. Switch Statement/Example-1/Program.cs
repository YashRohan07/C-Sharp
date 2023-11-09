using System;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet:");
            char ch = Convert.ToChar(Console.ReadLine()); // Read a line of text from the console and convert it to a character, then store it in 'ch'.

            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }

            Console.ReadLine();
        }
    }
}
