using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class Customer : Person
    {
        private Library _library;
        public Customer(Library library,int id, string name) : base(id, name)
        {
            _library = library;
        }

        public void BorrowBook (string isbn)
        {
            _library.BorrowBook(isbn);
        }
        public  void ReturnBook(string isbn)
        {
            _library.ReturnBook(isbn);
        }
    }
}