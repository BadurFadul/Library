namespace Library.src.Library;

public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book("john","bador", "14sd", 2015,false,true);
        Book book2 = new Book("Me IN CRIS","Soul", "1178", 2015,true,true);

        Library library1 = new Library();
        library1.AddBook(book1);
        library1.AddBook(book2);
        Customer customer1 = new Customer(library1,12, "Stephan");
        customer1.BorrowBook(book2.ISBN);
        Console.Write(library1.Books.Count() + "\n");
        Console.WriteLine(library1.BorrowedBooks.Count);
    }
}
