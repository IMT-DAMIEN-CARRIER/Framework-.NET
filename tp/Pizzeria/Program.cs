using System;
using System.Threading.Tasks;
using Pizzeria.Models;

namespace Pizzeria
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var context = new PizzeriaContext();
            
            var resto1 = new Restaurant { Name = "Resto 1"};
            var resto2 = new Restaurant { Name = "Resto 2"};
            context.Restaurants.Add(resto1);
            context.Restaurants.Add(resto2);

            var pizza1 = new Pizza{ Name = "Royal", Quantity = 1000, Restaurant = resto1};
            context.Pizzas.Add(pizza1);
            
            await context.SaveChangesAsync();
        }
    }
}
