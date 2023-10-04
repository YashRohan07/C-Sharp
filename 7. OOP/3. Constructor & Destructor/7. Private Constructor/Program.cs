using System;

namespace Private_Constructor
{
    class Car
    {
        //If a constructor is private, we can not create obj of the class
        private Car()  // Private constructor
        {
            Console.WriteLine("Private Constructor");
        }

        class CarDrive
        {
            static void Main(string[] args)
            {
                Car obj = new Car();  //Output: Private Constructor
                Console.ReadLine();  
            }
        }
    }
}
