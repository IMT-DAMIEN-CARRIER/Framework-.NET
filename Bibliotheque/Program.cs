using System;
using System.Collections.Generic;
using Bibliotheque.Entity;

namespace Bibliotheque
{
    class Program
    {

        private static Library _library = new();

        private static Dictionary<Type, Func<string, object>> _inputConverters =
            new Dictionary<Type, Func<string, object>>()
            {
                { typeof(string), str => str },
                { typeof(int), str => int.TryParse(str, out var x) ? x : -1 }
            };
        static void Main(string[] args)
        {
            _library.AddAvailabilityNotification(BookChanged);

            var str = GetInput<string>("string test :");
            Console.WriteLine($"Result : {str}");

            var x = GetInput<int>("int test : ");
            Console.WriteLine($"RESULT : {x.GetType()}");
        }

        private static void BookChanged(Livre book)
        {
            Console.WriteLine($"{book.Title}: {book.IsAvailable}");
        }

        private static T GetInput<T>(string label)
        {
            Console.WriteLine(label);

            if (!_inputConverters.ContainsKey(typeof(T)))
            {
                throw new NotImplementedException();
            }
            
            return (T)_inputConverters[typeof(T)](Console.ReadLine());
        }
    }
}
