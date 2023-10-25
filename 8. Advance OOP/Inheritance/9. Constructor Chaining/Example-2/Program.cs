using System;

namespace Constructor_Chaining
{
    // Base class User
    class User
    {
        // Default constructor
        public User()
        {
            Console.Write("Hi! ");
        }

        // Parameterized constructors with constructor chaining
        public User(string a) : this()
        {
            Console.Write(a);
        }

        public User(string a, string b) : this("welcome")
        {
            Console.Write(a + " " + b);
        }
    }

    // Derived class Student inheriting from User
    class Student : User
    {
        // Default constructor using base constructor chaining
        public Student() : base("", "to ")
        {
            Console.Write("CS Department. ");
        }

        // Parameterized constructors with constructor chaining
        public Student(string a) : base("Welcome ")
        {
            Console.Write(a);
        }

        public Student(string a, string b) : base(a, b)
        {
            Console.Write(" Student");
        }

        public Student(string a, string b, string c) : base(a, b)
        {
            Console.Write(" " + c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of User class
            User u1 = new User();
            Console.WriteLine(); // Hi!

            User u2 = new User("Hey");
            Console.WriteLine(); // Hi! Hey

            User u3 = new User("Welcome", "to Constructor Chaining");
            Console.WriteLine(); // Hi! welcome to Constructor Chaining

            // Creating instances of Student class
            Student s1 = new Student();
            Console.WriteLine(); // Hi! welcome to CS Department.

            Student s2 = new Student("Welcome to the");
            Console.WriteLine(); // Hi! Welcome to the

            Student s3 = new Student("Good", "Morning");
            Console.WriteLine(); // Hi! Good Morning Student

            Student s4 = new Student("Have", "a", "nice day!");
            Console.WriteLine(); // Hi! Have a nice day!

            Console.ReadLine();
        }
    }
}

/* 
 
Output:
Hi!
Hi! Hey
Hi! welcome to Constructor Chaining
Hi! welcome to CS Department.
Hi! Welcome to the
Hi! Good Morning Student
Hi! Have a nice day!

*/
