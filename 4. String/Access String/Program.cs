using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            //Accessing individual characters in the string
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


            string Info = "Cecilia Hansen is 25 years old";
            int start = Info.IndexOf("is") + 1;
            Console.WriteLine(start);  //16
            
            //string substring = Info.Substring(0, 6);  //Cecilia
            
            string substring = Info.Substring(start + 2, 2);
            Console.WriteLine("Age is " + substring);  //25
            
            for (int count = 0; count <= Info.Length - 1; count++)
            {
                Console.Write(Info[count]);   //Cecilia Hansen is 25 years old
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}

/*
H
e
1
2
2
World
16
Age is 25
Cecilia Hansen is 25 years old
*/
