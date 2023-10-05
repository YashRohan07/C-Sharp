using System;

class Person
{
    // Private field to store the person's age
    private int age;

    // Public getter method to retrieve the age
    public int GetAge()
    {
        return age;
    }

    // Public setter method to set the age
    public void SetAge(int newAge)
    {
        if (newAge >= 0 && newAge <= 120) 
        {
            age = newAge;
        }
        else
        {
            Console.WriteLine("Invalid age value.");
        }
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        // Set the age using the setter method
        person.SetAge(30);

        // Get and display the age using the getter method
        Console.WriteLine("Age: " + person.GetAge());

        person.SetAge(150); // This will display "Invalid age value."

        Console.ReadLine();
    }
}
