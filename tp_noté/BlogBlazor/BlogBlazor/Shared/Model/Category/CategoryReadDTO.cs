using System.Collections.Generic;
using BlogBlazor.Shared.Model.Post;

namespace BlogBlazor.Shared.Model.Category
{
    public class CategoryReadDTO
    {
        public string Name { get; set; }
        public List<PostReadDTO> Posts { get; set; }
    }
}