using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    internal delegate void IsAvailableChangedEventHandler(Book book);

    internal class Book
    {
        public Book(string iSBN, string name, string author)
        {
            ISBN = iSBN;
            Name = name;
            Author = author;
        }

        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }


        private bool _isAvailable;
        public bool IsAvailable
        {
            get { return _isAvailable; }
            set
            {
                if (_isAvailable != value)
                {
                    _isAvailable = value;
                    IsAvailableChanged?.Invoke(this);
                }
            }
        }

        public event IsAvailableChangedEventHandler IsAvailableChanged;


        public override string ToString() =>
            $"{nameof(ISBN)}: {ISBN}, {nameof(Name)}: {Name}, {nameof(Author)}: {Author}, {nameof(IsAvailable)}: {IsAvailable}";

        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book("1234", "livre 1", "author 1"),
                new Book("5678", "livre 2", "author 1"),
                new Book("9876", "livre 3", "author 2"),
                new Book("16374", "livre 4", "author 1"),
            };
        }
    }
}
