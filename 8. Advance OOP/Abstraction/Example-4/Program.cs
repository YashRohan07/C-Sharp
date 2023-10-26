using System;

namespace Abstract_Class_with_get_set
{
    // Abstract class representing a Vehicle
    abstract class Vehicle
    {
        // Protected field for brand
        protected string brand;

        // Abstract property for Brand with getter and setter
        public abstract string Brand
        {
            get;
            set;
        }
    }

    // Car class inheriting from Vehicle
    class Car : Vehicle
    {
        // Implementation of the Brand property using the protected field
        public override string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }

    // Motorcycle class inheriting from Vehicle
    class Motorcycle : Vehicle
    {
        // Implementation of the Brand property using the protected field
        public override string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Car class
            Car car = new Car();
            car.Brand = "Toyota";

            // Creating an instance of the Motorcycle class
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Brand = "Honda";

            // Getting and printing the brands of the car and motorcycle
            Console.WriteLine("Car brand: " + car.Brand);
            Console.WriteLine("Motorcycle brand: " + motorcycle.Brand);

            Console.ReadLine();
        }
    }
}
