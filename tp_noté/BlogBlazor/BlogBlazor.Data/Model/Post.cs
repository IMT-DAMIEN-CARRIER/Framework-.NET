using System.ComponentModel.DataAnnotations;

namespace BlogBlazor.Data.Model
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DataType PublicationDate { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}