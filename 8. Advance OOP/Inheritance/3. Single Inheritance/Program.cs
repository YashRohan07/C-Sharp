using System;

namespace Single_Level_Inheritance
{
    // Base class A
    class A
    {
        public int a;

        // Constructor of class A
        public A()
        {
            a = 9;
            Console.WriteLine("Constructor from class A.....");
        }
    }

    // Derived class B
    class B : A
    {
        public int b;

        // Constructor of class B
        public B()
        {
            b = 5;
            Console.WriteLine("Constructor from class B.....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the derived class B
            B obj = new B();
            Console.WriteLine("a = {0}", obj.a); // Accessing the member 'a' from the base class
            Console.WriteLine("b = {0}", obj.b); // Accessing the member 'b' from the derived class

            // Creating an instance of the base class A
            A obj2 = new A();
            Console.WriteLine("a = {0}", obj2.a); // Accessing the member 'a' from the base class
            //Console.WriteLine("b = {0}", obj2.b); // Invalid - Cannot access member 'b' of class B from class A

            Console.ReadLine();
        }
    }
}

/*
 Output:
Constructor from class A.....
Constructor from class B.....
a = 9
b = 5
Constructor from class A.....
a = 9


B obj = new B();: This line creates an instance of the derived class B. When this line is executed, the constructor of class A is invoked first,
as class B is derived from class A. The constructor of class A initializes the variable 'a' with the value 9. After the constructor of class A completes,
the constructor of class B is invoked, which initializes the variable 'b' with the value 5.

A obj2 = new A();: This line creates an instance of the base class A. When this line is executed, only the constructor of class A is invoked,
and the variable 'a' is initialized with the value 9. Since class A doesn't have access to the members of class B, the variable 'b' is not accessible in this context,
which is why the attempt to access it is marked as invalid.
 */
