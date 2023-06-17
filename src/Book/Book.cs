using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public abstract class Book
    {
        private string _title = String.Empty;
        private string _author = String.Empty;
        private string _isbn = String.Empty;
        private int _publicationYear;

        public string Title {get { return _title;}}
        public string Author {get { return _author;}}
        public string ISBN {get { return _isbn;}}
        public int PublicationYear {get {return _publicationYear;}}
        public bool CanBorrow {get; set;}
        public bool CanPrint {get; set;}
        
        public Book(string title, string author, string isbn, int publicationyear, bool canborrow, bool canprint)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
            _publicationYear = publicationyear;
            CanBorrow = canborrow;
            CanPrint = canprint;
        }

        public virtual void PrintInfo()
        {
            Console.Write($"Title: {Title}; Author: {Author}; ISBN: {ISBN}; Publication Year: {PublicationYear}; Can Borrow: {CanBorrow}; Can Print: {CanPrint}");
        }

    }
}