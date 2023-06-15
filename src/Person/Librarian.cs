using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class Librarian : Person
    {
        private Library _library;
        public Librarian(Library library ,int id, string name) : base(id, name)
        {
            _library = library;
        }
       public  void AddBook (Book book)
       {
            _library.AddBook(book);
       }
        public  void RemoveBook (Book book)
        {
            _library.RemoveBook(book);
        }
        public  void EditBook (string isbn, Book updatedbook)
        {
            _library.EditBook(isbn, updatedbook);
        }
    }
}