using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryMandatory2;

namespace BookAPI2.Managers
{
    public class BooksManager
    {
        public static Dictionary<string, Book> booksTest = new Dictionary<string, Book>()
        {

        };

        //get all books
        public IEnumerable<Book> GetAll()
        {
            return booksTest.Values;
        }
        //get book by ISBN method
        public Book GetBook(string ISBN)
        {
            return booksTest[ISBN];
        }

        public void CreateBook(Book newBook)
        {
            booksTest.Add(newBook.ISBN, newBook);
        }

        public void UpdateBook(string ISBN, Book newBook)
        {
            booksTest[ISBN].Author = newBook.Author;
            booksTest[ISBN].Title = newBook.Title;
            booksTest[ISBN].PageNumber = newBook.PageNumber;
        }

        public void DeleteBook(string ISBN)
        {
            booksTest.Remove(ISBN);
        }

    }
}