using Microsoft.EntityFrameworkCore;
using PizzaWebAssemblyApp.Shared;

namespace PizzaWebAssemblyApp.Server.Model
{
    public class MyContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        
        public MyContext(DbContextOptions options) : base(options)
        {
        }
    }
}