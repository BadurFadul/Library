using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class Novel : Book
    {
        public string Genre {get; set;}
        public Novel(string genre, string title, string author, string isbn, int publicationyear, bool canborrow, bool canprint) : base(title, author, isbn, publicationyear, canborrow, canprint)
        {
            Genre = genre;
        }
    }
}