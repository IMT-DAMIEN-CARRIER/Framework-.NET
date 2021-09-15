using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlogBlazor.Shared.Model;

namespace BlogBlazor.Client.Service
{
    public class AuthenticationService
    {
        private readonly HttpClient _httpclient;
        public Author Author { get; set; }

        public AuthenticationService(HttpClient Httpclient)
        {
            _httpclient = Httpclient;
        }

        public async Task Login(string email)
        {
            try
            {
                Author = await _httpclient.GetFromJsonAsync<Author>("api/author/" + email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Author not found");
            }
        }
    }
}