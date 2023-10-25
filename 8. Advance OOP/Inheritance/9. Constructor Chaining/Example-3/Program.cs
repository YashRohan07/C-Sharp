using System;

namespace ConstructorChainingExample
{
    class User
    {
        public User()
        {
            Console.Write("Hi! ");
        }

        public User(string message) : this()
        {
            Console.Write(message);
        }
    }

    class Student : User
    {
        public Student() : base("Welcome to ")
        {
            Console.Write("CS Department. ");
        }

        public Student(string status) : base("Welcome ")
        {
            Console.Write(status);
        }

        public Student(string status, string department) : base(status + department)
        {
            Console.Write(" - Enjoy your studies!");
        }

        // : base(status + department) --> it will concatenate the status and department strings and
        // pass the concatenated string as a parameter to the constructor of the base class
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine();  //Hi!

            User user2 = new User("Hey there!");
            Console.WriteLine();  //Hi! Hey there!

            Student student1 = new Student();
            Console.WriteLine();  //Hi! Welcome to CS Department.

            Student student2 = new Student("Proud Student");
            Console.WriteLine();  //Hi! Welcome Proud Student

            Student student3 = new Student("Welcome ", "to AIUB");
            Console.WriteLine();   //Hi! Welcome to AIUB - Enjoy your studies!

            Console.ReadLine();
        }
    }
}

/*
 Output:
Hi!
Hi! Hey there!
Hi! Welcome to CS Department.
Hi! Welcome Proud Student
Hi! Welcome to AIUB - Enjoy your studies!

 */