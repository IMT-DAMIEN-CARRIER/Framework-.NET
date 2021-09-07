using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpRequest
{
    public class Request
    {
        public String Url { get; set; }
        public HttpClient Client { get; set; }

        public Request(string url, HttpClient client)
        {
            Url = url;
            Client = client;
        }

        public static async Task<string> SendRequest(HttpClient client)
        {

            var response = await client.GetAsync("http://www.7timer.info/bin/api.pl?lon=113.17&lat=23.09&product=astro&output=json");
            if (response.IsSuccessStatusCode) return await response.Content.ReadAsStringAsync();
            return response.StatusCode.ToString();
        }
    }
}