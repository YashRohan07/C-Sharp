using System;

namespace ClassVsStructExample
{
    // Defining a class
    class MyClass
    {
        public int X;
    }

    // Defining a struct
    struct MyStruct
    {
        public int X;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using a class
            MyClass classObj1 = new MyClass();
            MyClass classObj2 = classObj1; // classObj2 is a reference to the same object as classObj1
            classObj1.X = 10;
            classObj2.X = 20; // Modifying classObj2 also modifies classObj1

            Console.WriteLine($"classObj1.X: {classObj1.X}"); // Output: 20
            Console.WriteLine($"classObj2.X: {classObj2.X}"); // Output: 20

            // Using a struct
            MyStruct structObj1 = new MyStruct();
            MyStruct structObj2 = structObj1; // structObj2 is a copy of structObj1
            structObj1.X = 10;
            structObj2.X = 20; // Modifying structObj2 does not affect structObj1

            Console.WriteLine($"structObj1.X: {structObj1.X}"); // Output: 10
            Console.WriteLine($"structObj2.X: {structObj2.X}"); // Output: 20

            Console.ReadLine();

            /*
             
             When working with classes, assigning one instance to another creates a reference to the same object in memory.
             Any changes made to one object will affect the other since they both point to the same instance.
             This is because classes are reference types.

             When working with structs, assigning one instance to another creates an independent copy of the data.
             Changes made to one struct instance will not affect the other, as they are separate entities.
             This is because structs are value types.


            - **Classes** are like a recipe for a cake. If you make changes to a cake, the original recipe remains the same,
              but any changes to the recipe affect all the cakes made from it.

            - **Structs** are like taking a photograph. If you make a copy of a photograph and then draw on one copy,
              the original photo remains unchanged, and the changes only appear on the copy.

             */
        }
    }
}
