using LibraryApp.Models;
using System;
using System.Collections.Generic;

namespace LibraryApp
{
    class Program
    {
        private static Library _library = new();

        private static Dictionary<Type, Func<string, object>> _inputConverters = new Dictionary<Type, Func<string, object>>
        {
            { typeof(string),  str => str},
            {typeof(int), str => int.TryParse(str, out var x) ? x : -1 }
        };

        static void Main(string[] args)
        {
            //_library.AddAvailibilityNotification(BookChanged);
            _library.AddAvailibilityNotification(book => Console.WriteLine($"{book.Name}: {book.IsAvailable}"));

            var str = GetInput<string>("string test: ");
            Console.WriteLine($"RESULT: {str}");

            var x = GetInput<int>("int test: ");
            Console.WriteLine($"RESULT: {x.GetType()}");
        }

        private static void BookChanged(Book book)
        {
            Console.WriteLine($"{book.Name}: {book.IsAvailable}");
        }

        private static T GetInput<T>(string label)
        {
            Console.Write(label);
            if (!_inputConverters.ContainsKey(typeof(T)))
                throw new NotImplementedException();
            return (T)_inputConverters[typeof(T)](Console.ReadLine());
        }
    }
}
