using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, result = 0;

            Console.WriteLine("Enter the first number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            char operatorSymbol;
            Console.WriteLine("Enter the operator (+, -, *, /):");
            operatorSymbol = Convert.ToChar(Console.Read());

            switch (operatorSymbol)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;

                case '-':
                    result = firstNumber - secondNumber;
                    break;

                case '*':
                    result = firstNumber * secondNumber;
                    break;

                case '/':
                    result = firstNumber / secondNumber;
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;


            }

            Console.WriteLine("The result is: " + result);

            Console.ReadLine();
        }
    }
}
