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
            ///String from Constructor
            char[] chars = { 'C', 'e', 'c', 'i', 'l', 'i', 'a' };
            string name = new string(chars);  // Creating a string from the chars array using the string constructor
            Console.WriteLine(name);  //Cecilia

            /// String from Literal
            string fname = "Cecilia";
            string lname = "Hansen";
            string age = "25";
            
            Console.WriteLine("First Name : {0}",fname);
            Console.WriteLine("Last Name  : {0}", lname);
            Console.WriteLine("Age        : {0}", age);
            
            /*
            Console.WriteLine("First Name : " + fname);
            Console.WriteLine("Last Name  : " + lname);
            Console.WriteLine("Age        : " + age);
            */

            string now = "Date : " + DateTime.Now.ToString("D");
            Console.WriteLine(now);  //Date : Friday, October 13, 2023

            now = "Date : " + DateTime.Now.ToString("MM-dd-yy");
            Console.WriteLine(now);  //Date : 10-13-23

            now = "Date : " + DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(now);  //Date : 11:44:31

            now = "Date : " + DateTime.Now.ToString();
            Console.WriteLine(now);  //Date : 10/13/2023 11:44:31 PM

            Console.Read();
        }
    }
}
/*
DateTime.Now  provides the current date and time, 
while the ToString method is used to convert the DateTime value into a string with various formatting options.
 */
