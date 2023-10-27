using System;

namespace Base
{
    // Base class A
    class A
    {
        public int a;

        // Constructor for class A
        public A(int x)
        {
            a = x;
            Console.WriteLine("Constructor A(int): a = {0}", a);  //Constructor A(int): a = 0
        }
    }

    // Derived class B from A
    class B : A
    {
        public int b;

        // Constructor for class B, calling the base class constructor with value 0
        public B(int y) : base(0)
        {
            b = y;
            Console.WriteLine("Constructor B(int): b = {0}", b);  //Constructor B(int): b = 4
        }
    }

    // Derived class C from B
    class C : B
    {
        public int c;

        // Constructor for class C, calling the base class constructor with value 0
        public C(int z) : base(0)
        {
            c = z;
            Console.WriteLine("Constructor C(int): c = {0}", c); //Constructor C(int): c = 5
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of class B
            B objB = new B(4);
            Console.WriteLine("------");  // ------

            // Creating an object of class C
            C objC = new C(5);

            Console.ReadLine();
        }
    }
}

/* 
Output:
Constructor A(int): a = 0
Constructor B(int): b = 4
------
Constructor A(int): a = 0
Constructor B(int): b = 0
Constructor C(int): c = 5
*/
