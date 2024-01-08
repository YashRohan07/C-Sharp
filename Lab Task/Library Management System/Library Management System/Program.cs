using System;

namespace Library_Management_System
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    class Library
    {
        public string LibName { get; set; }
        public string LibAddress { get; set; }
        public int TotalBook { get; private set; }

        Book[] listOfBooks;
        int size = 100;

        public Library() { }
        public Library(string libName, string libAddress)
        {
            LibName = libName;
            LibAddress = libAddress;
            listOfBooks = new Book[size];
        }

        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name: " + LibName);
            Console.WriteLine("Library Address: " + LibAddress);
            Console.WriteLine("Total Books: " + TotalBook);

            Console.WriteLine("List of Books:");
            for (int i = 0; i < TotalBook; i++)
            {
                Console.WriteLine($"Book {i + 1}: {listOfBooks[i].Title} by {listOfBooks[i].Author}");
            }
        }

        public void AddNewBook(Book book)
        {
            if (TotalBook < size)
            {
                listOfBooks[TotalBook] = book;
                TotalBook++;
                Console.WriteLine($"Added: {book.Title} by {book.Author}");
            }
            else
            {
                Console.WriteLine("Library is full, cannot add more books.");
            }
        }

        public void DeleteBook(Book book)
        {
            for (int i = 0; i < TotalBook; i++)
            {
                if (listOfBooks[i] == book)
                {
                    // Shift books to fill the gap
                    for (int j = i; j < TotalBook - 1; j++)
                    {
                        listOfBooks[j] = listOfBooks[j + 1];
                    }
                    listOfBooks[TotalBook - 1] = null;
                    TotalBook--;
                    Console.WriteLine($"Deleted: {book.Title} by {book.Author}");
                    return;
                }
            }
            Console.WriteLine("Book not found in the library.");
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            for (int i = 0; i < copy; i++)
            {
                AddNewBook(book);
            }
        }

        static void Main(string[] args)
        {
            Library myLibrary = new Library("My Library", "123");
            Book book1 = new Book("Book1", "Author1");
            Book book2 = new Book("Book2", "Author2");

            myLibrary.AddNewBook(book1);
            myLibrary.AddNewBook(book2);

            myLibrary.ShowLibInfo();

            myLibrary.DeleteBook(book1);

            myLibrary.ShowLibInfo();

            Console.ReadLine();
        }
    }

   
}
