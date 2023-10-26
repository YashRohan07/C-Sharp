using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_with_Constructor
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
           Console.WriteLine("Dog Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();

            Console.ReadLine();
        }
    }
}

/*
 
Output:
Animal Constructor
Dog Constructor

 */
