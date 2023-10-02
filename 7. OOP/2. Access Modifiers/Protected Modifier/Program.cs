using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Protected access modifier can only be accessed from the same class and its derived classes.
namespace Protected_Access_Modifier
{
    class student
    {
        protected string name = "Yash";
    }

    // Derived class
    class Program : student
    {
        static void Main(string[] args)
        {
            //Creating object of derived class
            Program obj = new Program();

            Console.WriteLine(obj.name);
            Console.ReadLine();
        }
    }
}
