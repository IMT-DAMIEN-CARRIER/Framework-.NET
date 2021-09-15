using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Models;

namespace Blog.Shared.DTO
{
    public class CategoryReadDTO
    {
        
        public Int64 Id { get; set; }

        public string Name { get; set; }
    }
}
