using System;
using System.Collections.Generic;

namespace console
{
    public class Contact
    {
        private Guid _guid = Guid.NewGuid();

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string lastname, string firstname, string phoneNumber)
        {
            Lastname = lastname;
            Firstname = firstname;
            PhoneNumber = phoneNumber;
        }

        public static void CreateContact()
        {
            //TODO
        }

        public static void DeleteContact()
        {
            //TODO
        }

        public static void UpdateContact()
        {
            //TODO
        }

        public static void GetContacts(Dictionary<int, Contact> contacts)
        {
            Console.WriteLine("Voici la liste des contact");

            if (0 != contacts.Count)
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(
                        $"{contact.Value.Firstname} {contact.Value.Lastname} : {contact.Value.PhoneNumber}"
                    );
                }
            } else {
                Console.WriteLine("La liste de contact est vide");
            }
        }
    }
}