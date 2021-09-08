using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Models
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pizzeria.db");
        }
    }
}