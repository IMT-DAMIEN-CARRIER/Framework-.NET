using System;
using System.Collections.Generic;
using static console.Contact;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new Dictionary<int, Contact>();
            var exit = false;

            Affichage();

            while (!exit)
            {
                var response = Console.ReadLine();
                
                switch (response)
                {
                    case "1":
                        Console.WriteLine("Vous avez choisi l'option de création d'un contact");
                        break;
                    case "2":
                        Console.WriteLine("Vous avez choisi l'option de modification d'un contact");
                        break;
                    case "3":
                        Console.WriteLine("Vous avez choisi l'option de suppression d'un contact");
                        break;
                    case "4":
                        GetContacts(contacts);

                        break;
                    case "q":
                        exit = true;
                        break;
                }
                
                if (!exit)
                {
                    Affichage();
                }
                
                Console.WriteLine();
            }
        }

        private static void Affichage()
        {
            Console.WriteLine("Bonjour & Bienvenu");
            Console.WriteLine("Que voulez vous faire ?");
            Console.WriteLine("1) Créer un contact");
            Console.WriteLine("2) Modifier un contact");
            Console.WriteLine("3) Supprimer un contact");
            Console.WriteLine("4) Lister les contacts");
            Console.WriteLine("q) Quitter");
            Console.WriteLine();
        }
    }
}
