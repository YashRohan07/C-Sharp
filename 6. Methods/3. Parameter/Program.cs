using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    internal class Program
    {
        static void Method1(string name) //Single parameter
        {
            Console.WriteLine("Name: " +name);
        }

        static void Method2(string name, int age)  //Multiple parameter
        {
            Console.WriteLine("Name: " +name + " & Age: " +age);
        }

        static void Method3(string country = "Canada") //Default parameter
        {
            Console.WriteLine(country);  // a parameter with a default value is known as optional parameter,,Here country is optional parameter
        }
        static void Main(string[] args)
        {
            Method1("Yash"); //Calling the single parameterized method

            Method2("Rohan", 22);  //Calling the multiple parameterized method

            Method3();  //If we call the method without an argument, it uses the default value ("Canada")
            Method3("USA");

            Console.ReadLine();

        }
    }
}
