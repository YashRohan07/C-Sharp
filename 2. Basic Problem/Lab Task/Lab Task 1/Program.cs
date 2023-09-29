/* Write a program which ask for a student score. Score is a number from 0 to 100. 
Translate the score into grade like A,B...F. */
using System;

namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            char letterGrade;

            if (marks >= 90 && marks <= 100)
            {
                letterGrade = 'A';
            }
            else if (marks >= 80 && marks < 90)
            {
                letterGrade = 'B';
            }
            else if (marks >= 70 && marks < 80)
            {
                letterGrade = 'C';
            }
            else if (marks >= 60 && marks < 70)
            {
                letterGrade = 'D';
            }
            else if (marks >= 0 && marks < 60)
            {
                letterGrade = 'F';
            }
            else
            {
                Console.WriteLine("Invalid marks");
                return;
            }

            
            Console.WriteLine("Your grade is:" +letterGrade);

            Console.ReadLine();
        }
    }
}
