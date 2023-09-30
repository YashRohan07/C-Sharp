using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Yash";
            string lastName = "Rohan";

            // $ sign is used for interpolation method..
            string name = $"My name is: {firstName} {lastName}";
            Console.WriteLine(name);

            string message = $"Welcome {firstName}"; //Using firstName variable inside the message string
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
