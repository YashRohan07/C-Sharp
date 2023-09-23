using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            Console.WriteLine(str[0]); // Output: H
            Console.WriteLine(str[1]); // Output: e

            // Finding index position
            Console.WriteLine(str.IndexOf("e")); // Output: 1
            Console.WriteLine(str.IndexOf("l")); // Output: 2
            Console.WriteLine(str.IndexOf("l")); // Output: 2

            // Substring() method
            int charPos = str.IndexOf("W");    
            string lastName = str.Substring(charPos);
            Console.WriteLine(lastName);  // World

            Console.ReadLine();

        }
    }
}
