using System;

namespace Course_Management_System
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseCredit { get; set; }
        public Student[] EnrolledStudents { get; set; }

        public Course(string courseName, string courseCode, int courseCredit)
        {
            CourseName = courseName;
            CourseCode = courseCode;
            CourseCredit = courseCredit;
            EnrolledStudents = new Student[30];
        }

        public void AddStudent(Student student)
        {
            for (int i = 0; i < EnrolledStudents.Length; i++)
            {
                if (EnrolledStudents[i] == null)
                {
                    EnrolledStudents[i] = student;
                    return;
                }
            }
        }

        public void RemoveStudent(Student student)
        {
            for (int i = 0; i < EnrolledStudents.Length; i++)
            {
                if (EnrolledStudents[i] == student)
                {
                    EnrolledStudents[i] = null;
                    return;
                }
            }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Course Code: {CourseCode}");
            Console.WriteLine($"Course Credit: {CourseCredit}");

            Console.WriteLine("List Of Enrolled Students:");
            foreach (var student in EnrolledStudents)
            {
                if (student != null)
                {
                    Console.WriteLine($"Student Name: {student.Name}, ID: {student.ID}");
                }
            }
        }
    }
}
