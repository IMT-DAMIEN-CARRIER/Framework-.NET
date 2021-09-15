using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        public DateTime PublicationDate { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [JsonIgnore]
        public Author Author { get; set; }
    }
}