

namespace Library.src.Library
{
    public class Novel : Book, IBorrowable
    {
        public string Genre {get; set;}
        public Novel(string genre, string title, string author, string isbn, int publicationyear, bool canborrow = true, bool canprint = false) : base(title, author, isbn, publicationyear, canborrow, canprint)
        {
            Genre = genre;
        }

        public void BorrowBook()
        {
            Console.Write("Novel books can be borrowed");
        }

        public void ReturnBook()
        {
            Console.WriteLine("Novel books can be returned");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Genre {Genre}");
        }
    }
}