using System;
using System.Collections.Generic;

namespace Book
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopies;
        private static int bookCounter;

        public Book() { }
        public Book(string name, string author, string id, string type, int copies)
        {
            bookName = name;
            bookAuthor = author;
            bookId = id;
            bookType = type;
            bookCopies = copies;
            bookCounter++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Book Name: {bookName}");
            Console.WriteLine($"Author: {bookAuthor}");
            Console.WriteLine($"Book ID: {bookId}");
            Console.WriteLine($"Book Type: {bookType}");
            Console.WriteLine($"Number of Copies: {bookCopies}");
        }

        public void AddBookCopy(int x)
        {
            bookCopies += x;
            Console.WriteLine($"{x} copies added. Total copies now: {bookCopies}");
        }

        public static void ShowTotalBookInfo()
        {
            Console.WriteLine($"Total books: {bookCounter}");
        }
    }

    class Library
    {
        public string LibName { get; set; }
        public string LibAddress { get; set; }
        public List<Book> ListOfBook { get; set; }
        public int TotalBook { get; set; }

        public Library()
        {
            ListOfBook = new List<Book>();
        }

        public Library(string name, string address) : this()
        {
            LibName = name;
            LibAddress = address;
        }

        public void ShowLibInfo()
        {
            Console.WriteLine($"Library Name: {LibName}");
            Console.WriteLine($"Library Address: {LibAddress}");
            Console.WriteLine("Books:");
            foreach (Book book in ListOfBook)
            {
                book.ShowInfo();
            }
        }

        public void AddNewBook(Book book)
        {
            ListOfBook.Add(book);
            TotalBook++;
        }

        public void DeleteBook(Book book)
        {
            ListOfBook.Remove(book);
            TotalBook--;
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            foreach (Book b in ListOfBook)
            {
                if (b == book)
                {
                    b.AddBookCopy(copy);
                    break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library("Public Library", "123 Main St");

            Book book1 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "9780439708180", "Fantasy", 3);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", "Classic", 2);

            myLibrary.AddNewBook(book1);
            myLibrary.AddNewBook(book2);

            Console.WriteLine("Library Information:");
            myLibrary.ShowLibInfo();

            Book newBook = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", "Classic", 5);

            myLibrary.AddNewBook(newBook);
            myLibrary.AddNewBookCopy(book1, 2);

            Console.WriteLine("\nLibrary Information after adding new book and copies:");
            myLibrary.ShowLibInfo();

            myLibrary.DeleteBook(book2);

            Console.WriteLine("\nLibrary Information after deleting a book:");
            myLibrary.ShowLibInfo();

            Book.ShowTotalBookInfo();

            Console.ReadLine();
        }
    }
}
