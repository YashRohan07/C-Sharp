using System;

namespace MyInfo_Updated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Information...");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("University Name: ");
            string university = Console.ReadLine();

            Console.Write("Department: ");
            string department = Console.ReadLine();

            Console.Write("Student ID: ");
            string studentID = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("CGPA: ");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Email Address: ");
            string email = Console.ReadLine();

            Console.Write("Blood Group: ");
            string bloodGroup = Console.ReadLine();

            Console.Write("Contact Number: ");
            int contactNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Account Balance: ");
            double accountBalance = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
