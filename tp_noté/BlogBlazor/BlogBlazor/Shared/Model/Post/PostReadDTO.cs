using System.ComponentModel.DataAnnotations;
using BlogBlazor.Shared.Model.Author;
using BlogBlazor.Shared.Model.Category;

namespace BlogBlazor.Shared.Model.Post
{
    public class PostReadDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DataType PublicationDate { get; set; }
        public CategoryReadDTO Category { get; set; }
        public AuthorReadDTO Author { get; set; }
    }
}