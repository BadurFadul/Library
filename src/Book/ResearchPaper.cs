using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class ResearchPaper : Book, IPrintable
    {
         private int _pageCount;
        private int _maxaPrint = 10;

        public int PageCount 
        {
            get 
            {
                return _pageCount;
            }
            set
            {
                if(value < 100 || value > 500 )
                {
                    throw new Exception("Page count must be between 100 and 500");
                }
                _pageCount = value;
            }
        }
        public int MaxPrint {get {return _maxaPrint;}}
        public ResearchPaper(string title, string author, string isbn, int publicationyear,int pageCount, bool canborrow = false, bool canprint = true) : base(title, author, isbn, publicationyear, canborrow, canprint)
        {
            PageCount = pageCount;
        }

         public void PrintPages(int startPage, int endPage)
        {
            if(endPage - startPage > _maxaPrint)
            {
                Console.WriteLine($"Cannot print more than {_maxaPrint} pages at a time.");
            }
            else if (startPage < 1 || endPage > _pageCount)
            {
                Console.WriteLine("Invalid page numbers provided.");
            }
            else
            {
                 Console.WriteLine($"Printing pages {startPage} to {endPage} of {this.Title}.");
            }
        }

        public override void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}