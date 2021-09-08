using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpRequest
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new HttpClient();
            
            await Task.WhenAll(
                Request.SendRequest(client),
                Request.SendRequest(client),
                Request.SendRequest(client),
                Request.SendRequest(client),
                Request.SendRequest(client)
            );
            Console.WriteLine("Finished");
        }
    }
}
