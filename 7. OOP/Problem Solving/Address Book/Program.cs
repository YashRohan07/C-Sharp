using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string personId { get; set; }
        public int age { get; set; }
        public char gender { get; set; }

        public Contact() { }
        public Contact(string PName, string Pid, string Number, int Age, char Gender)
        {
            Name = PName;
            personId = Pid;
            PhoneNumber = Number;
            age = Age;
            gender = Gender;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {personId}, Age: {age}, Gender: {gender}, Number: {PhoneNumber}");
        }

        public void ShowContactInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }

    class AddressBook
    {
        public string OwnerName { get; set; }
        public string Info { get; set; }
        public List<Contact> ListOfContact { get; set; }

        public AddressBook()
        {
            ListOfContact = new List<Contact>();
        }

        public AddressBook(string owner, string information) : this()
        {
            OwnerName = owner;
            Info = information;
        }

        public void ShowAllContactInfo()
        {
            Console.WriteLine($"Address Book Owner: {OwnerName}");
            Console.WriteLine($"Additional Information: {Info}");
            Console.WriteLine("Contacts:");
            foreach (var contact in ListOfContact)
            {
                contact.ShowContactInfo();
            }
        }

        public void AddContact(Contact con)
        {
            ListOfContact.Add(con);
        }

        public void DeleteContact(Contact con)
        {
            ListOfContact.Remove(con);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AddressBook myAddressBook = new AddressBook("John Doe", "Some information");

            Contact contact1 = new Contact { Name = "Yash", PhoneNumber = "01738360521" };
            Contact contact2 = new Contact { Name = "Rohan", PhoneNumber = "01834070547" };

            myAddressBook.AddContact(contact1);
            myAddressBook.AddContact(contact2);

            myAddressBook.ShowAllContactInfo();

            Contact C = new Contact("Yash", "202", "01738360521", 22, 'M');
            C.ShowInfo();
            Contact T = new Contact("Rohan", "2033", "01834070547", 23, 'M');
            T.ShowInfo();

            // Add more contacts
            Contact contact3 = new Contact { Name = "Jane", PhoneNumber = "0123456789" };
            myAddressBook.AddContact(contact3);

            Console.WriteLine("\nUpdated Address Book:");
            myAddressBook.ShowAllContactInfo();

            // Delete a contact
            Console.WriteLine("\nDeleting a contact...");
            myAddressBook.DeleteContact(contact2);
            myAddressBook.ShowAllContactInfo();

            Console.ReadLine();
        }

    }
}
