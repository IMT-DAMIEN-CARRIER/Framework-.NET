using Blog.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blog.Client.Service
{
    public class AuthenticationService
    {
        private readonly HttpClient _http;

        public AuthorReadDTO LoggedAuthor { get; set; }

        public AuthenticationService(HttpClient http)
        {
            _http = http;
        }

        public bool isConnected()
        {
            return LoggedAuthor != null;
        }

        public async Task tryLogin(AuthorLoginDTO author)
        {
            var response = await _http.PostAsJsonAsync("api/Author/authenticate", author);
            if (response.IsSuccessStatusCode)
            {
                LoggedAuthor = await response.Content.ReadFromJsonAsync<AuthorReadDTO>();
            }
        }
    }
}
