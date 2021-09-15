using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Models
{
    public class Post
    {
        [Required]
        public Int64 Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Int64 CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public Int64 AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
