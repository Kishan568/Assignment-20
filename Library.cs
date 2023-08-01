using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    public class Library
    {
        static List<Book> books;
        public Library()
        {
            books = new List<Book>()
            {
                new Book() {BookId=1,Title="Head first c#",Author="Andrew Stellman",Genre="2007",IsAvailable=true},
                new Book() {BookId=2,Title="Concurrency in C#",Author="Stephen Cleary",Genre="2014",IsAvailable=true},
                new Book() {BookId=3,Title="Pro .Net 2.0",Author="Matthew MacDonald",Genre="2005",IsAvailable=true},
                new Book() {BookId=4,Title="Programming C# 5.0",Author="Ian Griffiths",Genre="2012",IsAvailable=true},
                new Book() {BookId=5,Title="C# 6.0 and the .NET 4.6 Framework",Author="Andrew Troelsen",Genre="2015",IsAvailable=true}
            };
        }
        public void AddBook(Book b)
        {
            books.Add(b);
            Console.WriteLine("List of books");
            this.ViewAllBook();
        }
        public void ViewAllBook()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Book Id: " + book.BookId);
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("IsAvailable: " + book.IsAvailable);
            }
        }
        public void SearchBookById(int id)
        {
            foreach (Book book in books)
            {
                if (book.BookId == id)
                {
                    Console.WriteLine("Book Id: " + book.BookId);
                    Console.WriteLine("Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Genre: " + book.Genre);
                    Console.WriteLine("IsAvailable: " + book.IsAvailable);
                }
            }
        }
        public void SearchBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine("Book Id: " + book.BookId);
                    Console.WriteLine("Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Genre: " + book.Genre);
                    Console.WriteLine("IsAvailable: " + book.IsAvailable);
                }
            }
        }
    }
}