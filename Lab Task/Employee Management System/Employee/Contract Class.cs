using System;

namespace Employee
{
    class ContractEmployee : Employee
    {
        private int salary;

        public ContractEmployee() { }
        public ContractEmployee(string name, string age, int salary) : base(name, age)
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
