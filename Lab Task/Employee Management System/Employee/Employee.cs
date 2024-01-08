using System;

namespace Employee
{
    class Employee
    {
        private string name;
        private string age;

        public Employee() { }
        public Employee(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
