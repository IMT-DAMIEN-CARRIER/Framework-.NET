using Microsoft.EntityFrameworkCore;
using PizzaDemo.Data.Models;

namespace PizzaDemo.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
