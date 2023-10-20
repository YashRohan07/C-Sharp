using System;

namespace StructExample
{
    // Defining a struct 
    struct Student
    {
        public string Name;
        public int Age;
        public string Course;

        // Constructor for initializing the student
        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }

        // Method for displaying student information
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Student struct
            Student student = new Student("John Doe", 20, "Computer Science");

            // Accessing the fields of the struct
            Console.WriteLine("Name: " +student.Name);

            //Accessing the methods of the struct
            student.Display();

            Console.ReadLine();
        }
    }
}
