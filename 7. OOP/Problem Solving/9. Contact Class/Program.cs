using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Class
{
    class Contact
    {
        public string personName { get; set; }
        public string personId { get; set; }
        public string mobileNumber { get; set; }
        public int age { get; set; }
        public char gender { get; set; }

        public Contact() { }
        public Contact(string PName, string Pid, string Number, int Age, char Gender)
        {
            personName = PName;
            personId = Pid;
            mobileNumber = Number;
            age = Age;
            gender = Gender;
        }

        public void showInfo()
        {
            Console.WriteLine($"Name: {personName}, ID: {personId}, Age: {age}, Gender: {gender}, Number: {mobileNumber}");
        }

        public void DetectMobileOperator()
        {
            if (mobileNumber[2] == '7')
            {
                Console.WriteLine("GrameenPhone");
            }
            else if (mobileNumber[2] == '8')
            {
                Console.WriteLine("Robi");
            }
            else
            {
                Console.WriteLine("Other Operator");
            }
        }

        static void Main(string[] args)
        {
            Contact C = new Contact("Yash", "202", "01738360521", 22, 'M');

            C.showInfo();
            C.DetectMobileOperator();
            
            Contact T = new Contact("Rohan", "2033", "01834070547", 23, 'M');

            T.showInfo();
            T.DetectMobileOperator();

            Console.ReadLine();
        }
    }
}
