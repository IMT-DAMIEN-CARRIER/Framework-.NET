using System.Collections.Generic;
using BlogBlazor.Shared.Model.Post;

namespace BlogBlazor.Shared.Model.Author
{
    public class AuthorReadDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<PostReadDTO> Posts { get; set; }
    }
}