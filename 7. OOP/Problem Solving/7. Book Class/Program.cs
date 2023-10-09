using System;

namespace Book
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopies;
        static int bookCounter;

        public Book() { }
        public Book(string name, string author, string id, string type, int copies)
        {
            bookName = name;
            bookAuthor = author;
            bookId = id;
            bookType = type;
            bookCopies = copies;
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

        static void ShowTotalBookInfo()
        {
            Console.WriteLine($"Total books: {bookCounter}");
        }

        static void Main(string[] args)
        {
            Book myBook = new Book("The Catcher in the Rye", "J.D. Salinger", "123456", "Fiction", 5);

            myBook.ShowInfo();
            myBook.AddBookCopy(3);

            bookCounter++;
            ShowTotalBookInfo();

            Console.ReadLine();
        }
    }
}
