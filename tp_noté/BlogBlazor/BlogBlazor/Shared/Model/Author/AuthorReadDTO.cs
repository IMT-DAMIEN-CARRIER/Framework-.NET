using System.Collections.Generic;
using BlogBlazor.Shared.Model.Post;

namespace BlogBlazor.Shared.Model.Author
{
    public class AuthorReadDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}