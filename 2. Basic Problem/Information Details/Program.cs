using System;

namespace MyInfo_Updated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, university, dept, id, email, bg;
            double balance, cgpa;
            int age, contact;

            Console.WriteLine("Enter Your Info...");

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter University Name: ");
            university = Console.ReadLine();

            Console.Write("Enter Dept: ");
            dept = Console.ReadLine();

            Console.Write("Enter Your ID: ");
            id = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter CGPA: ");
            cgpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Email: ");
            email = Console.ReadLine();

            Console.Write("Enter Blood Group: ");
            bg = Console.ReadLine();

            Console.Write("Contact Number: ");
            contact = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Net Worth: ");
            balance = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
