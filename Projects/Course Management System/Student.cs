using System;

namespace Course_Management_System
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Department { get; set; }
        public float CGPA { get; set; }
        public Course[] EnrolledCourses { get; set; }

        public Student()
        {
            EnrolledCourses = new Course[5];
        }

        public void EnrollInCourse(Course course)
        {
            for (int i = 0; i < EnrolledCourses.Length; i++)
            {
                if (EnrolledCourses[i] == null)
                {
                    EnrolledCourses[i] = course;
                    course.AddStudent(this);
                    return;
                }
            }
        }

        public void DropCourse(Course course)
        {
            for (int i = 0; i < EnrolledCourses.Length; i++)
            {
                if (EnrolledCourses[i] == course)
                {
                    EnrolledCourses[i] = null;
                    course.RemoveStudent(this);
                    return;
                }
            }
        }

        public void ShowEnrolledCourses()
        {
            Console.WriteLine($"Student Name: {Name}, ID: {ID}, Department: {Department}, CGPA: {CGPA}");

            Console.WriteLine("Enrolled Courses:");
            foreach (var course in EnrolledCourses)
            {
                if (course != null)
                {
                    Console.WriteLine($"Course Name: {course.CourseName}, Course Code: {course.CourseCode}");
                }
            }
        }
    }
}
