using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Models;

namespace Blog.Shared.DTO
{
    public class PostWriteDTO
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Content { get; set; }
        
        public Int64 CategoryId { get; set; }
        
        public Int64 AuthorId { get; set; }
    }
}
