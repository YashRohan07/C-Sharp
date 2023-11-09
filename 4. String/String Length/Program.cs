using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create String
            string str = "C# Programming";
            Console.WriteLine("String: " +str);  //String: C# Programming

            //Get Length of str
            int length = str.Length;
            Console.WriteLine("Length: " + length);  //Length: 15

            Console.ReadLine();
        }
    }
}
