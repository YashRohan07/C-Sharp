using System;

namespace Assembly
{
    class Student
    {
        internal string name = "Rohan";
    }

    class Program
    {
        static void Main(string[] args)
        {

            // creating object of Student class
            Student obj = new Student();

            // accessing name field and printing it
            Console.WriteLine("Name: " + obj.name);
            Console.ReadLine();
        }
    }
}