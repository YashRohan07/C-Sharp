using System;

namespace Example_1
{
    class Car
    {
        // Fields (class members)
        private string color = "Black";  
        private int speed = 200;         
        private string model;           

        public void Sound()  //Method
        {
            Console.WriteLine("Very CooooL!");
        }

        static void Main(string[] args)
        {
            // ClassName obj = new ClassName()
            Car myObj = new Car();

            Console.WriteLine("Color: " + myObj.color);
            Console.WriteLine("Speed: " + myObj.speed);

            // Modify the car's model
            myObj.model = "V805";
            Console.WriteLine("Model: " + myObj.model);

            // Call the "Sound" method 
            myObj.Sound();

            Console.ReadLine();
        }
    }
}
