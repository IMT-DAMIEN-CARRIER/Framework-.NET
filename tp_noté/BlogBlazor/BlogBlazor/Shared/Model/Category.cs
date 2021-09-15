using System.Collections.Generic;

namespace BlogBlazor.Shared.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}