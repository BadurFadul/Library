using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Abstract.Library
{
    public abstract class CustomerActions
    {
        public abstract void BorrowBook (string isbn);
        public abstract void ReturnBook(string isbn);
    }
}