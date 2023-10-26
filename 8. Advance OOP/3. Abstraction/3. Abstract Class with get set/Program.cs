using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_with_get_set
{
    abstract class Animal
    {
        protected string name;

        public abstract string Name
        {
            get;
            set;
        }
    }

    class Dog : Animal
    {
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();

            obj.Name = "Munem";
            Console.WriteLine(obj.Name);
            Console.ReadLine();
        }
    }
}
