using System;

namespace Course
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course() { }

        public Course(string name, string code, int credit)
        {
            courseName = name;
            courseCode = code;
            courseCredit = credit;
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Course Code: {courseCode}");
            Console.WriteLine($"Course Credit: {courseCredit}");
        }

        static void Main(string[] args)
        {
            Course myCourse = new Course("OOP2", "101", 3);
            myCourse.ShowCourseInfo();
            Console.ReadLine();
        }

        /*
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
