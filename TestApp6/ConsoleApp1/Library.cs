using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace andrestech.learning2022.krasn
{
    public delegate void NewBookHandler(string message);

    [LogLevel(7)]
    internal class Library
    {
        public event NewBookHandler NewBook;
        public List<Book> Books { get; set; }

        public Library(List<Book> books)
        {
            Books = books;
        }
        
       
        public bool Add(Book book)
        {
            Books.Add(book);
            NewBook?.Invoke($"New Book \"{book.Title}\" in catalog! Hurry up!");
            return true;
        }
    }
}
