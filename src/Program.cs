namespace Library.src.Library;

public class Program
{
    public static void Main(string[] args)
    {


        Library library1 = new Library();
        Customer customer = new Customer(library1,1, "John Doe");
        Librarian librarian = new Librarian(library1,2, "Jane Doe");

        //Create books and add to library
        Comic comic1 = new Comic("Tom and Jerry", "Samuel Soul","111", 2020, "Maria");

        Novel novel1 = new Novel("Fiction", "A Novel Book", "Novel Author", "456", 2023);
        TextBook textbook = new TextBook("A TextBook", "TextBook Author", "789", 2023, 200);
        ResearchPaper researchPaper = new ResearchPaper("Interface paper", "Research Author", "000", 2023, 150);

        library1.AddBook(comic1);
        library1.AddBook(novel1);
        library1.AddBook(textbook);
        librarian.AddBook(researchPaper);
        customer.BorrowBook("111");
        
        novel1.PrintInfo();
        researchPaper.PrintPages(10, 20);

        Console.Write(library1.Books.Count() + "\n");
        Console.WriteLine(library1.BorrowedBooks.Count);
    }
}
