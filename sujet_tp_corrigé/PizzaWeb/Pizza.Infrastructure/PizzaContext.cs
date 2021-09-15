using Microsoft.EntityFrameworkCore;
using Pizza.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Infrastructure
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza.Domain.Pizza> Pizzas { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Order> Order { get; set; }

        public PizzaContext(DbContextOptions options) : base(options)
        {
        }
    }
}
