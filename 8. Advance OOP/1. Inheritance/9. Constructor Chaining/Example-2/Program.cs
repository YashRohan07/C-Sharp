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

The User class has three constructors:
User(): This is the default constructor that prints "Hi! " to the console.
User(string a): This constructor takes a string parameter a and this() keyword calls the default constructor User(). It then prints the value of a to the console.
User(string a, string b): This constructor takes two string parameters a and b and uses the this() keyword to call the second constructor User(string a).


The Student class inherits from the User class and has four constructors:
Student(): This constructor uses the base keyword to call the constructor User("", "to "), resulting in the output "Hi! welcome to CS Department. ".
Student(string a): This constructor uses the base keyword to call the constructor User("Welcome ") and prints the value of a.
Student(string a, string b): This constructor uses the base keyword to call the constructor User(a, b) from the User class.
Student(string a, string b, string c): This constructor uses the base keyword to call the constructor User(a, b) from the User class and then prints the value of c.



1. **User u1 = new User();**
   - This creates an instance of the User class using the default constructor, which prints "Hi!"

2. **User u2 = new User("Hey");**
   - This creates an instance of the User class using the parameterized constructor that takes a string parameter.
   The `this` keyword chains the current constructor to the default constructor, and then the value of the string "Hey" is printed to the console.

3. **User u3 = new User("Welcome", "to Constructor Chaining");**
   - This creates an instance of the User class using the parameterized constructor that takes two string parameters.
   The `this` keyword in the constructor chains to the User(string a) constructor. 
   The `base` keyword in the User(string a, string b) constructor chains to the User(string a) constructor.

4. **Student s1 = new Student();**
   - This creates an instance of the Student class using the default constructor.
   The `base` keyword in the Student() constructor chains to the User class constructor with parameters. Then, "CS Department." is printed

5. **Student s2 = new Student("Welcome to the");**
   - This creates an instance of the Student class using the parameterized constructor.
   The `base` keyword in the Student(string a) constructor chains to the User(string a) constructor, which in turn chains to the default constructor.
   The string "Welcome to the" is then printed to the console.

6. **Student s3 = new Student("Good", "Morning");**
   - This creates an instance of the Student class using the parameterized constructor.
   The `base` keyword in the Student(string a, string b) constructor chains to the User(string a, string b) constructor, which chains to the User(string a) constructor.
   The string "Good Morning Student" is printed to the console.

7. **Student s4 = new Student("Have", "a", "nice day!");**
   - This creates an instance of the Student class using the parameterized constructor.
   The `base` keyword in the Student(string a, string b, string c) constructor chains to the User(string a, string b) constructor,
   which chains to the User(string a) constructor. The string "Have a nice day!" is printed to the console.

Output:
Hi!
Hi! Hey
Hi! welcome to Constructor Chaining
Hi! welcome to CS Department.
Hi! Welcome to the
Hi! Good Morning Student
Hi! Have a nice day!

*/
