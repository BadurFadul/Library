
namespace Library.src.Library
{
    public class Library
    {
        private Dictionary<string, Book> _books = new();
        private Dictionary<int, Person> _people = new();
        private List<Book> _borrowedBooks = new();

        public Dictionary<string, Book> Books {get {return _books;}}
        public List<Book> BorrowedBooks {get {return _borrowedBooks;}}

        public Library ()
        {
            _books = new Dictionary<string, Book>();
            _people = new Dictionary<int, Person>();
            _borrowedBooks = new List<Book>();
        }

        public  void AddBook (Book book)
        {
            if(_books.ContainsKey(book.ISBN))
            {
                throw new Exception("book with the sam isbn already exist in the library");
            }
            _books.Add(book.ISBN, book);
        }

        public void RemoveBook (Book book)
        {
            if(!_books.ContainsKey(book.ISBN))
            {
                throw new Exception("Selected book does not exist in the database");
            }
            _books.Remove(book.ISBN);
        }

        public void BorrowBook (string isbn)
        {
            if(!_books.ContainsKey(isbn))
            {
                throw new Exception("Selected book does not exist in the library");
            }
            if(_books[isbn].CanBorrow == false)
            {
                throw new Exception("Sorry!, selected book can not be borrowed");
            }
            if(_borrowedBooks.Exists(c => c.ISBN == isbn))
            {
                throw new Exception("selected book is already borrowed");
            }
            var book = _books[isbn];
            _borrowedBooks.Add(book);
        }

        public void ReturnBook (string isbn)
        {
            if(!_books.ContainsKey(isbn))
            {
                throw new Exception("Selected book does not exist in the library");
            }
            var borrowedBook = _borrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
            if(borrowedBook == null)
            {
                throw new Exception("Selected book was not borrowed");
            }
            _borrowedBooks.Remove(borrowedBook);
        }

        public void EditBook (string isbn, Book updatedbook)
        {
            
            if(!_books.ContainsKey(isbn))
            {
                throw new Exception("Selected book does not exist in the database");
            }
            var oldbook = _books[isbn];
            if(oldbook.ISBN != updatedbook.ISBN && _books.ContainsKey(updatedbook.ISBN))
            {
                throw new Exception("selected isbn alreadt exist in the library");
            }
            _books[updatedbook.ISBN] = updatedbook;
        }

        public List<Book> GetAvailableBooks()
        {
            return _books.Values.Except(_borrowedBooks).ToList();
        }

        public void AddPerson(Person person)
        {
            if(_people.ContainsKey(person.Id))
            {
                 throw new Exception("person with the sam Id already exist in the library");
            }
            _people.Add(person.Id,person);
        }

        public void RemovePerson(Person person)
        {
            if(!_people.ContainsKey(person.Id))
            {
                 throw new Exception("person does not exist in the library");
            }
            _people.Remove(person.Id);
        }

        public void EditPerson (int id, string name)
        {
            if(_people.ContainsKey(id))
            {
                throw new Exception("Selected person does not exist in the library");
            }
            var person = _people[id];
            person.Name = name;
        }

    }
}