using System;
using System.Collections.Generic;
using System.Linq;
using Bibliotheque.Entity;
using Bibliotheque.Events;

namespace Bibliotheque
{
    internal enum BorrowResult
    {
        BookNotFound,
        PersonNotFound,
        BookNotAvailable,
        Ok
    }

    internal enum ReturnResult
    {
        BookNotFound,
        PersonNotFound,
        Ok
    }
    
    internal class Library
    {
        private List<Person> _people = new List<Person>();
        private List<Livre> _books = new List<Livre>();

        public void Registration(Person p) => _people.Add(p);
        public void AddBook(Livre l) => _books.Add(l);

        public Person GetPerson(Guid id) => _people.FirstOrDefault(x => x.Id == id);

        public Livre GetBook(string isbn) => _books.FirstOrDefault(x => x.ISBN == isbn);

        public IEnumerable<Livre> SearchBooks(string query) =>
            _books.Where(
                x => x.ISBN.Contains(query) || x.Title.Contains(query) ||
                     x.Author.Firstname.Contains(query) || x.Author.Lastname.Contains(query)
            );

        public void AddAvailabilityNotification(BookIsAvailableEvent.IsAvailableChangeEventHandler callback)
        {
            foreach (var book in _books)
            {
                book.IsAvailableChangedEvent += callback;
            }
        }

        public BorrowResult Borrow(Guid personId, string isbn)
        {
            var book = GetBook(isbn);
            var person = GetPerson(personId);

            if (book == null) return BorrowResult.BookNotFound;
            if (!book.IsAvailable) return BorrowResult.BookNotAvailable;
            if (person == null) return BorrowResult.PersonNotFound;

            book.IsAvailable = false;
            person.Livres.Add(book.ISBN, book);

            return BorrowResult.Ok;
        }

        public ReturnResult Return(Guid personId, string isbn)
        {
            var book = GetBook(isbn);
            var person = GetPerson(personId);

            if (book == null) return ReturnResult.BookNotFound;
            if (person == null) return ReturnResult.PersonNotFound;
            
            book.IsAvailable = true;
            person.Livres.Remove(book.ISBN);

            return ReturnResult.Ok;
        }
    }
}