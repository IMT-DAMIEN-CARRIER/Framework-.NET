using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal enum BorrowResult
    {
        BookNotFound,
        PersonNotFound,
        BookNotAvailable,
        OK
    }

    internal enum ReturnResult
    {
        BookNotFound,
        PersonNotFound,
        Ok
    }

    internal class Library
    {
        private List<Person> _people;
        private List<Book> _books;

        public Library()
        {
            _people = Person.GetPeople();
            _books = Book.GetBooks();
        }

        public void Registration(Person p) => _people.Add(p);
        public void AddBook(Book b) => _books.Add(b);
        public Person GetPerson(int id) => _people.FirstOrDefault(x => x.Id == id);
        public Book GetBook(string isbn) => _books.FirstOrDefault(x => x.ISBN == isbn);
        public IEnumerable<Book> SearchBooks(string query) =>
            _books.Where(x => x.ISBN.Contains(query) || x.Name.Contains(query) || x.Author.Contains(query));

        public void AddAvailibilityNotification(IsAvailableChangedEventHandler callback)
        {
            foreach (var item in _books)
                item.IsAvailableChanged += callback;
        }

        public BorrowResult Borrow(int personId, string isbn)
        {
            var book = GetBook(isbn);
            
            if (book == null) return BorrowResult.BookNotFound;
            if (!book.IsAvailable) return BorrowResult.BookNotAvailable;

            var person = GetPerson(personId);
            if (person == null) return BorrowResult.PersonNotFound;

            book.IsAvailable = false;
            person.Books.Add(book);
            return BorrowResult.OK;
        }

        public ReturnResult Return(int personId, string isbn)
        {
            var book = GetBook(isbn);

            if (book == null) return ReturnResult.BookNotFound;

            var person = GetPerson(personId);
            if (person == null) return ReturnResult.PersonNotFound;

            book.IsAvailable = true;
            person.Books.Remove(book);
            return ReturnResult.Ok;
        }
    }
}
