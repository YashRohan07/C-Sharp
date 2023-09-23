using System;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch statement with grouped cases..
            char ch;
            Console.WriteLine("Enter an alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());

            switch(Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Not a vowel");
                    break;

            }

            Console.ReadLine();
        }
    }
}
