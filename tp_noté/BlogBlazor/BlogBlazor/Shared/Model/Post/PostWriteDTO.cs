using System.ComponentModel.DataAnnotations;
using BlogBlazor.Shared.Model.Author;
using BlogBlazor.Shared.Model.Category;

namespace BlogBlazor.Shared.Model.Post
{
    public class PostWriteDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DataType PublicationDate { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}