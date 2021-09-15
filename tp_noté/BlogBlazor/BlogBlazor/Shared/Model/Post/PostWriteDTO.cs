using System;
using System.ComponentModel.DataAnnotations;
using BlogBlazor.Shared.Model.Author;
using BlogBlazor.Shared.Model.Category;

namespace BlogBlazor.Shared.Model.Post
{
    public class PostWriteDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}