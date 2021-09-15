using BlogBlazor.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogBlazor.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public MyContext(DbContextOptions options) : base(options)
        {
        }
    }
}