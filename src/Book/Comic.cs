using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class Comic : Book, IBorrowable
    {
        public string Artist {get; set;}

        public Comic(string title, string author, string isbn, int publicationyear, string artist, bool canborrow = true, bool canprint=false) : base(title, author, isbn, publicationyear, canborrow, canprint)
        {
            Artist = artist;
        }

        public void BorrowBook()
        {
             Console.WriteLine("Comic books can be borrowed");
        }

        public void ReturnBook()
        {
            Console.WriteLine("Comic books can be returned");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Artist {Artist}");
        }
    }
}