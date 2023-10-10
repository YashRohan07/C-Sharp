using System;

namespace CourseName
{
    //Using Property
    class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseCredit { get; set; }

        public Course(string courseName, string courseCode, int courseCredit)
        {
            CourseName = courseName;
            CourseCode = courseCode;
            CourseCredit = courseCredit;
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Course Code: {CourseCode}");
            Console.WriteLine($"Course Credit: {CourseCredit}");
        }

        static void Main(string[] args)
        {
            Course myCourse = new Course("OOP2", "101", 3);
            myCourse.ShowCourseInfo();
            Console.ReadLine();
        }
    }
}

        /*
        //Without using property
        class course
       {
        private string courseName;
        private string accId;
        private int courseCredit;

        public void showInfo()
        {
            Console.WriteLine("Course Name: " +courseName);
            Console.WriteLine("Course ID: " + accId);
            Console.WriteLine("Course Credit: " + courseCredit);

        }
        static void Main(string[] args)
        {
            course c = new course();

            c.courseName = "Javascript";
            c.courseCredit = 3;
            c.accId = "223";

            c.showInfo();
            Console.ReadLine();
        }
         */
    }
}
