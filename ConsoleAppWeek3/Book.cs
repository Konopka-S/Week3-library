using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }
      
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be empty.");
                }
            }
        }
            
        


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