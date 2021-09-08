using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public static void CreateContact(Dictionary<Guid, Contact> contacts)
        {
            Console.WriteLine();
            Console.WriteLine("Création d'un contact");
            Console.WriteLine("Firstname : ");
            Guid guid = Guid.NewGuid();
            
            var firstname = Console.ReadLine();
            Console.WriteLine("Lastname : ");
            var lastname = Console.ReadLine();
            Console.WriteLine("PhoneNumber : ");
            var phonenumber = Console.ReadLine();

            var contact = new Contact(lastname, firstname, phonenumber);
            
            contacts.Add(guid, contact);
            
            GetContacts(contacts);
        }

        public static void DeleteContact(Dictionary<Guid, Contact> contacts)
        {
            var error = true;
            GetContacts(contacts);

            while (error)
            {
                Console.WriteLine();
                Console.WriteLine("Quel contact voulez vous supprimer ?");
                var value = Console.ReadLine();
                
                if (value != null)
                {
                    var valueInt = int.Parse(value);

                    if (contacts.Count >= valueInt)
                    {
                        contacts.Remove(Guid.Parse(value));
                        Console.WriteLine();
                        Console.WriteLine("Le contact a bien été supprimé");
                        Console.WriteLine();
                        error = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("La value entrée est incorrecte.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Vous ne pouvez pas entrer une valeur nulle.");
                    Console.WriteLine();
                }
            }
        }

        public static void UpdateContact(Dictionary<Guid, Contact> contacts)
        {
            var error = true;
            GetContacts(contacts);

            while (error)
            {
                Console.WriteLine();
                Console.WriteLine("Quel contact voulez vous mettre à jour ?");
                var value = Console.ReadLine();
                
                if (value != null)
                {
                    var valueInt = int.Parse(value);

                    if (contacts.Count >= valueInt)
                    {
                        var contact = contacts[Guid.Parse(value)];
                        
                        Console.WriteLine();
                        Console.WriteLine("Voici le contact choisi :");
                        Console.WriteLine($"{contact.Firstname} {contact.Lastname} : {contact.PhoneNumber}");
                        Console.WriteLine();
                        Console.WriteLine("Nouveau Prénom : (Vide si inchangé)");
                        var firstname = Console.ReadLine();

                        if (firstname != "")
                        {
                            contact.Firstname = firstname;
                        }
                        
                        Console.WriteLine("Nouveau Nom : (Vide si inchangé)");
                        var lastname = Console.ReadLine();

                        if (lastname != "")
                        {
                            contact.Lastname = lastname;
                        }
                        
                        Console.WriteLine("Nouveau Numéro de téléphone : (Vide si inchangé)");
                        var phonenumber = Console.ReadLine();
                        
                        if (phonenumber != "")
                        {
                            contact.PhoneNumber = phonenumber;
                        }

                        error = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("La value entrée est incorrecte.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Vous ne pouvez pas entrer une valeur nulle.");
                    Console.WriteLine();
                }
            }
        }

        public static void GetContacts(Dictionary<Guid, Contact> contacts)
        {
            Console.WriteLine("Voici la liste des contact");

            if (0 != contacts.Count)
            {
                var i = 0;
                foreach (var contact in contacts)
                {
                    Console.WriteLine(
                        $"{i} : {contact.Value.Firstname} {contact.Value.Lastname} : {contact.Value.PhoneNumber}"
                    );
                }
            } else {
                Console.WriteLine("La liste de contact est vide");
            }
        }
    }
}