using System;
using System.Collections.Generic;
using Bibliotheque.Events;

namespace Bibliotheque.Entity
{
    public class Livre
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Person Author { get; set; }
        private bool _IsAvailable { get; set; }

        public bool IsAvailable
        {
            get { return _IsAvailable; }
            set
            {
                if (_IsAvailable != value)
                {
                    _IsAvailable = value;
                    IsAvailableChangedEvent?.Invoke(this);
                }
            }
        }

        public event BookIsAvailableEvent.IsAvailableChangeEventHandler IsAvailableChangedEvent;

        public Livre(string isbn, string title, Person author, bool isAvailable)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            _IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            if (IsAvailable)
            {
                return $"{ISBN} - {Title} by {Author.Firstname} {Author.Lastname} is available";
            }
            
            return $"{ISBN} - {Title} by {Author.Firstname} {Author.Lastname} is not available";
        }

        public static Dictionary<string, Livre> MockLivres()
        {
            var books = new Dictionary<string, Livre>();
            
            var author = new Person("James", "Joyce");
            var id = new Guid().ToString("N");
            var book = new Livre(id, "ULYSSES", author, true);
            books.Add(id, book);

            author = new Person("F.", "Scott Fitzgerald");
            id = new Guid().ToString("N");
            book = new Livre(id, "THE GREAT GATSBY", author, false);
            
            books.Add(id, book);
            
            return books;
        }
    }
}