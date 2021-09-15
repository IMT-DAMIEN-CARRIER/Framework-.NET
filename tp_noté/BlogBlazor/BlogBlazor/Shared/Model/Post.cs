using System.ComponentModel.DataAnnotations;

namespace BlogBlazor.Shared.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DataType PublicationDate { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
    }
}