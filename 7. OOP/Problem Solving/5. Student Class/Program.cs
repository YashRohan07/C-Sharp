using System;

namespace Student_Class
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Dept Name: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
        }

        static void Main(string[] args)
        {
            Student s = new Student();

            s.name = "Yash";
            s.id = "22-46636-1";
            s.department = "CSE";
            s.cgpa = 1.50f; //Use "1.50f" for a float value

            s.ShowInfo();
            Console.ReadLine();
        }
    }
}


/*
    class Student
    {
        // Automatic Property
        public string Name { get; set; }
        public string ID { get; set; }
        public string Department { get; set; }
        public float CGPA { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Dept Name: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
        }

        static void Main(string[] args)
        {
            Student s = new Student();

            s.Name = "Yash";
            s.ID = "22-46636-1";
            s.Department = "CSE";
            s.CGPA = 1.50f;

            s.ShowInfo();
            Console.ReadLine();
        }
    }
*/

/*
    
    class student
    {
        string name;
        string id;
        string department;
        float cgpa;

        public void showInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Dept Name: " + department);
            Console.WriteLine("CGPA: " + cgpa);
        }

        static void Main(string[] args)
        {
            student s = new student();

            s.name = "Yash";
            s.id = "22-46636-1";
            s.department = "CSE";
            s.cgpa = 3;

            s.showInfo();
            Console.ReadLine();
        }
    }
 */

