using System;

namespace Course_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Yash";
            s1.ID = "22-46636-1";
            s1.Department = "CSE";
            s1.CGPA = 1.50f;

            Student s2 = new Student();
            s2.Name = "Virat";
            s2.ID = "22-46636-2";
            s2.Department = "CSE";
            s2.CGPA = 2.50f;

            Student s3 = new Student();
            s3.Name = "Rohan";
            s3.ID = "22-46636-3";
            s3.Department = "CSE";
            s3.CGPA = 3.00f;

            Course c1 = new Course("OOP1", "101", 3);
            Course c2 = new Course("DSA", "102", 3);
            Course c3 = new Course("OOP2", "103", 3);

            s1.EnrollInCourse(c1);
            s1.EnrollInCourse(c2);
            s1.EnrollInCourse(c3);

            s2.EnrollInCourse(c1);
            s2.EnrollInCourse(c2);
            s2.EnrollInCourse(c3);

            s3.EnrollInCourse(c1);
            s3.EnrollInCourse(c2);
            s3.EnrollInCourse(c3);

            s1.DropCourse(c2);

            Console.WriteLine("Enrolled courses for Yash:\n");
            s1.ShowEnrolledCourses();

            Console.WriteLine("\nEnrolled courses for Virat:\n");
            s2.ShowEnrolledCourses();

            Console.WriteLine("\nEnrolled courses for Rohan:\n");
            s3.ShowEnrolledCourses();

            Console.WriteLine("\nAll course information:\n");

            Console.WriteLine("Registered students for OOP1\n");
            c1.ShowCourseInfo();

            Console.WriteLine("\nRegistered students for DSA:\n");
            c2.ShowCourseInfo();

            Console.WriteLine("\nRegistered students for OOP2:\n");
            c3.ShowCourseInfo();

            Console.ReadLine();
        }
    }
}
