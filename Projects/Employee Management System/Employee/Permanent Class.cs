using System;

namespace Employee
{
    class PermanentEmployee : Employee
    {
        private int salary;

        public PermanentEmployee() { }
        public PermanentEmployee(string name, string age, int salary) : base(name, age)
        {
            this.salary = salary;
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
