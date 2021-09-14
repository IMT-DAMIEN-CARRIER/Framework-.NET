using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using PizzaApi.Models;

namespace PizzaApi.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }

    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Pizza> Pizzas { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
    }

    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<PizzaApi.Models.Order> Order { get; set; }
    }
}
