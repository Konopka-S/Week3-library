using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;

        // Example of a constructor that allows us to 'construct' a new
        // Book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}

    