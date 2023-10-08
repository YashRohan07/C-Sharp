using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_variable_vs_Instance_variable
{
    class Student
    {
        static public string schoolName = "AIUB";  //Static variable
        public string studentName; //Instance variable
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.studentName = "Yash";

            Console.WriteLine("Name: " + obj.studentName); //Calling the instance variable
            Console.WriteLine("School: " + Student.schoolName); //Calling the static variable

            Console.ReadLine();
        }
    }
}

/*
 
Output:
Name: Yash
School: AIUB

 */
