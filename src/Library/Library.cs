using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class Library
    {
        private Dictionary<string, Book> _books = new();
        private List<Book> _borrowedBooks = new();

        public Dictionary<string, Book> Books {get {return _books;}}
        public List<Book> BorrowedBooks {get {return _borrowedBooks;}}

        public void AddBook (Book book)
        {
            if(_books.ContainsKey(book.ISBN))
            {
                throw new Exception("book with the sam isbn already exist in the library");
            }
            _books.Add(book.ISBN, book);
        }

        public void RemoveBook (Book book)
        {
            if(!_books.ContainsKey(book.ISBN))
            {
                throw new Exception("Selected book does not exist in the database");
            }
            _books.Remove(book.ISBN);
        }

        public void BorrowBook (string isbn)
        {
            if(!_books.ContainsKey(isbn))
            {
                throw new Exception("Selected book does not exist in the library");
            }
            if(_books[isbn].CanBorrow == false)
            {
                throw new Exception("Sorry!, selected book can not be borrowed");
            }
            if(_borrowedBooks.Exists(c => c.ISBN == isbn))
            {
                throw new Exception("selected book is already borrowed");
            }
            var book = _books[isbn];
            _borrowedBooks.Add(book);
        }

        public void ReturnBook (string isbn)
        {
            if(!_books.ContainsKey(isbn))
            {
                throw new Exception("Selected book does not exist in the library");
            }
            var borrowedBook = _borrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
            if(borrowedBook == null)
            {
                throw new Exception("Selected book was not borrowed");
            }
            _borrowedBooks.Remove(borrowedBook);
        }

        public List<Book> GetAvailableBooks()
        {
            return _books.Values.Except(_borrowedBooks).ToList();
        }

    }
}