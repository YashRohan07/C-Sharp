using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    class A
    {
        public int a;
        public A()
        {
            a = 1;
            Console.WriteLine("Constructor from class A");
        }
    }

    class B : A
    {
        public int b;
        public B()
        {
            b = 2;
            Console.WriteLine("Constructor from class B");
        }
    }

    class C : A
    {
        public int c;
        public C()
        {
            c = 3;
            Console.WriteLine("Constructor from class C");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            Console.WriteLine("a = {0} ", obj1.a);
            //Console.WriteLine("b = {0} ", obj1.b);
            Console.WriteLine("c = {0} ", obj1.c);

            Console.WriteLine();

            B obj2 = new B();
            Console.WriteLine("a = {0} ", obj2.a);
            Console.WriteLine("b = {0} ", obj2.b);
            //Console.WriteLine("c = {0} ", obj2.c);

            Console.WriteLine();

            A obj3 = new A();
            Console.WriteLine("a = {0} ", obj3.a);
            //Console.WriteLine("b = {0} ", obj3.b);
            //Console.WriteLine("c = {0} ", obj3.c);

            Console.ReadLine();
        }
    }
}

/*
 Output:

Constructor from class A
Constructor from class C
a = 1
c = 3

Constructor from class A
Constructor from class B
a = 1
b = 2

Constructor from class A
a = 1

 */
