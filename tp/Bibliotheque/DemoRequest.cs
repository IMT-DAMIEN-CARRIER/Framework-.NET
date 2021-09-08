using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class DemoRequest
    {
        public async Task Start()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://google.com");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
        }
    }
}