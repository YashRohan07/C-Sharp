using System;

namespace InheritanceAndInvoking
{
    // Base class 
    class BaseClass
    {
        // Constructor of BaseClass
        public BaseClass()
        {
            Console.WriteLine("Constructor of BaseClass is invoked.");
        }

        // Method to display 
        public void DisplayMessage()
        {
            Console.WriteLine("DisplayMessage method of BaseClass");
        }
    }

    // Derived class that inherits from BaseClass
    class DerivedClass : BaseClass
    {
        // Constructor of DerivedClass
        public DerivedClass()
        {
            Console.WriteLine("Constructor of DerivedClass is invoked.");
        }

        // Method to display
        public void ShowMessage()
        {
            Console.WriteLine("ShowMessage method of DerivedClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of DerivedClass
            DerivedClass obj = new DerivedClass();

            // Invoking the DisplayMessage method of BaseClass
            obj.DisplayMessage();

            // Invoking the ShowMessage method of DerivedClass
            obj.ShowMessage();

            Console.ReadLine();
        }
    }
}

/*
Output:
Constructor of BaseClass is invoked.
Constructor of DerivedClass is invoked.
DisplayMessage method of BaseClass
ShowMessage method of DerivedClass


When you create an object of the `DerivedClass`, the constructor of the `BaseClass` is automatically executed before the constructor of the `DerivedClass`. 
After creating the object, you can use both the `DisplayMessage` method from the `BaseClass` and the `ShowMessage` method defined in the `DerivedClass`. 
The program then displays appropriate messages for each method call.

 */