using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Student
    {
        //AUTO IMPLEMENTED PROPERTY
        public int ID { get; set; }
        public string NAME { get; set; }

        /*
        public int ID { get; private set; }
        public string NAME { get; private set; }
        */

        public Student(int i, string n)
        {
            ID = i;
            NAME = n;
        }

    }
    class Program
    {
        static void Main(string[] args)
        { 
            Student s = new Student(111, "Virat");

            Console.WriteLine(s.ID);
            Console.WriteLine(s.NAME);

            Console.Read();
        }
    }
}
