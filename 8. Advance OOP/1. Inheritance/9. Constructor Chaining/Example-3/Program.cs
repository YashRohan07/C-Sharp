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

1. **User user1 = new User();**
   - The `user1` object is created using the default constructor of the `User` class. It prints "Hi! " to the console.

2. **User user2 = new User("Hey there!");**
   - The `user2` object is created using the parameterized constructor of the `User` class. 
   The `this` keyword is used to chain the current constructor to the default constructor, then prints "Hi! Hey there!" 

3. **Student student1 = new Student();**
   - The `student1` object is created using the default constructor of the `Student` class, 
   which uses the `base` keyword to call the base class constructor with the parameter "Welcome to ". It prints "Hi! Welcome to CS Department. "

4. **Student student2 = new Student("Proud Student");**
   - The `student2` object is created using the parameterized constructor of the `Student` class.
   The `base` keyword in the constructor calls the base class constructor with the parameter "Welcome ", and "Proud Student" is printed to the console.

5. **Student student3 = new Student("Welcome ", "to AIUB");**
   - The `student3` object is created using the parameterized constructor of the `Student` class.
   The `base` keyword in the constructor concatenates the `status` and `department` strings and passes the concatenated string as a parameter to the constructor of the base class.
   This results in "Hi! Welcome to AIUB - Enjoy your studies!" being printed to the console.
   The `base` keyword here is used for constructor chaining, and it connects the derived class to the base class constructors by passing the necessary parameters.
   
Output:
Hi!
Hi! Hey there!
Hi! Welcome to CS Department.
Hi! Welcome Proud Student
Hi! Welcome to AIUB - Enjoy your studies!

 */
