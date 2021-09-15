using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blog.Data.Models
{
    public class Category
    {
        [Required]
        public Int64 Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}
