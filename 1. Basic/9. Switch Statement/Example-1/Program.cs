using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch; //Variable 'ch' is used to store character.
            Console.WriteLine("Enter an alphabet:");
            ch = Convert.ToChar(Console.ReadLine()); // Read a line of text from the console and convert it to a character, then store it in 'ch'.

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;

                case 'e':
                    Console.WriteLine("vowel");
                    break;

                case 'i':
                    Console.WriteLine("vowel");
                    break;

                case 'o':
                    Console.WriteLine("vowel");
                    break;

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
