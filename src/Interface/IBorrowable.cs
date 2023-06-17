using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public interface IBorrowable
    {
         void BorrowBook ();
         void ReturnBook();
    }
}