using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class Comic : Book
    {
        public string Artist {get; set;}

        public Comic(string artist,string title, string author, string isbn, int publicationyear, bool canborrow, bool canprint) : base(title, author, isbn, publicationyear, canborrow, canprint)
        {
            Artist = artist;
        }
    }
}