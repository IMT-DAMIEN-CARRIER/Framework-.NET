using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    internal class Person
    {
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; } = new();

        public override string ToString() => 
            $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}";

        public static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person(1, "user 1", "user 1"),
                new Person(2, "user 2", "user 2"),
                new Person(3, "user 3", "user 3")
            };
        }

    }
}
