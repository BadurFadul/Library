using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public abstract class LibrarianActions
    {
        public abstract void AddBook (Book book);
        public abstract void RemoveBook (Book book);
        public abstract void EditBook (string isbn, Book updatedbook);
    }

}