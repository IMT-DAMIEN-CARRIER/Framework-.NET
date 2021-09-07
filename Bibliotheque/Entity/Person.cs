using System;
using System.Collections.Generic;

namespace Bibliotheque.Entity
{
    public class Person
    {
        public Guid Id = new Guid();
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Dictionary<string, Livre> Livres { get; set; } = new Dictionary<string, Livre>();
        
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string ToString()
        {
            var countLivres = Livres.Count;
            
            if (countLivres > 1)
            {
                return $"{Id} - {Firstname} {Lastname} : {countLivres} livres";
            }

            return $"{Id} - {Firstname} {Lastname} : {countLivres} livre";
        }

        public static Dictionary<Guid, Person> MockPerson()
        {
            var authors = new Dictionary<Guid, Person>();

            var author = new Person("James", "Joyce");
            authors.Add(author.Id, author);

            author = new Person("F.", "Scott Fitzgerald");
            authors.Add(author.Id, author);
            
            return authors;
        }
    }
}