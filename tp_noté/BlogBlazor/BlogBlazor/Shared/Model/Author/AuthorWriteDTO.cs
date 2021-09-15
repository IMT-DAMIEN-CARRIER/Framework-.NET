using System.ComponentModel.DataAnnotations;

namespace BlogBlazor.Shared.Model.Author
{
    public class AuthorWriteDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}