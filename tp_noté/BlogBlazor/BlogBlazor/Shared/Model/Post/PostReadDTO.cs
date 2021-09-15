using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BlogBlazor.Shared.Model.Author;
using BlogBlazor.Shared.Model.Category;

namespace BlogBlazor.Shared.Model.Post
{
    public class PostReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Content { get; set; }
        public CategoryReadDTO Category { get; set; }
        public AuthorReadDTO Author { get; set; }
    }
}