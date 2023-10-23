using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level__inheritance
{
    class A
    {
        public int a;
        public A()
        {
            a = 1;
            Console.WriteLine("From A Class");
        }

    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 2;
            Console.WriteLine("From B Class");
        }

    }
    class C : B
    {
        public int c;
        public C()
        {
            c = 3;
            Console.WriteLine("From C Class");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            Console.WriteLine("a = {0}", obj1.a);
            ////Console.WriteLine("b = {0}", obj1.b);
            ////Console.WriteLine("c = {0}", obj1.c);

            Console.WriteLine("     ");

            B obj2 = new B();
            Console.WriteLine("a = {0}", obj2.a);
            Console.WriteLine("b = {0}", obj2.b);
            ////Console.WriteLine("c = {0}", obj2.c);
          
            Console.WriteLine("     ");

            C obj3 = new C();
            Console.WriteLine("a = {0}", obj3.a);
            Console.WriteLine("b = {0}", obj3.b);
            Console.WriteLine("c = {0}", obj3.c);

            Console.ReadLine();
        }
    }
}

/*
Output:

From A Class
a = 1

From A Class
From B Class
a = 1
b = 2

From A Class
From B Class
From C Class
a = 1
b = 2
c = 3


 */
