using System;

namespace SubstringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello, world!";

            // Using Substring to get a portion of the original string
            string substring1 = data.Substring(7);  //Outputs "world!"
            Console.WriteLine(substring1);

            // Using Substring to get a portion of the original string starting at a specific index with a specified length
            string substring2 = data.Substring(0, 5);  //Outputs "Hello"
            Console.WriteLine(substring2);

            
            string meta = "This is an example string.";

            // Extracting a portion of the string starting at index 5 and length 2
            string substring3 = meta.Substring(5, 2);  //Outputs "is"
            Console.WriteLine(substring3);

            Console.ReadLine();
        }
    }
}
