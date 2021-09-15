using System;
using Demo3.Models;
using System.IO;
using Demo3.Services;
using System.Collections.Generic;

namespace Demo3
{
    class Program
    {
        private static Dictionary<Type, Func<string, object>> _inputConverters = new Dictionary<Type, Func<string, object>>
        {
            { typeof(String), str => str },
            { typeof(int), str => int.TryParse(str, out var x) ? x : -1 }
        };
        private static List<Contact> _data = new List<Contact>();
        private static IOutput _output;
        static void Main(string[] args)
        {
            _output = new FileOutput();
            _output.WriteFinished += WriteFinished;

            bool exit = false;
            while (!exit)
            {
                PrintMenu();
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreateContact();
                        break;
                    case "2":
                        EditContact();
                        break;
                    case "3":
                        DeleteContact();
                        break;
                    case "4":
                        GetContacts();
                        break;
                    case "q":
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            _output.Write("1) Creer un contact");
            _output.Write("2) modifier un contact");
            _output.Write("3) supprimer un contact");
            _output.Write("4) lister les contacts");
            _output.Write("q) Quitter");
        }

        private static void CreateContact()
        {
            var firstName = GetInput<string>("firstname: ");
            var lastName = GetInput<string>("lastName: ");
            var phone = GetInput<string>("phone: ");
            var c = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
            };
            _data.Add(c);
        }

        private static void EditContact()
        {
            GetContacts();
            var index = GetInput<int>("index: ");
            if(index != -1)
            {
                var firstName = GetInput<string>("firstname: ");
                var lastName = GetInput<string>("lastName: ");
                var phone = GetInput<string>("phone: ");
                var c = new Contact
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                };
                _data[index] = c;
            }
            else
            {
                _output.Write("????");
            }
        }

        private static void GetContacts()
        {
            for (int i = 0; i < _data.Count; i++)
            {
                var item = _data[i];
                if (item != null)
                {
                    _output.Write($"{i}: {item}");
                }
            }
        }

        private static void DeleteContact()
        {
            GetContacts();
            var index = GetInput<int>("index: ");
            if (index != -1)
            {
                _data.RemoveAt(index);
            }
            else
            {
                _output.Write("????");
            }
        }

        private static T GetInput<T>(string label)
        {
            _output.Write(label);
            var input = Console.ReadLine();
            if(!_inputConverters.ContainsKey(typeof(T)))
                throw new NotImplementedException();

            return (T)_inputConverters[typeof(T)](input);
        } 

        private static void WriteFinished()
        {
            System.Console.WriteLine("WriteFinished");
        }
    }
}
