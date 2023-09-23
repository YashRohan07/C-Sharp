using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Yash ";
            string lastName = "Rohan";

            //Using the + operator for concatenation 
            string name1 = firstName + lastName;
            Console.WriteLine(name1);

            //Using the string.Concat() method for concatenation 
            string name2 = string.Concat(firstName, lastName);
            Console.WriteLine(name2);

            Console.ReadLine();

        }
    }
}
