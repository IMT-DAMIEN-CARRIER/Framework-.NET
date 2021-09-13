using Microsoft.EntityFrameworkCore;
using PizzaEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEF
{
    class Program
    {
        private static PizzaContext _context = new();
        async static Task Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1) ajouter un restaurant");
                Console.WriteLine("2) ajouter une pizza");
                Console.WriteLine("3) commander une pizza");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        await FormRestaurant();
                        break;
                    case "2":
                        await FormPizza();
                        break;
                    case "3":
                        await Command();
                        break;
                    default:
                        exit = true;
                        break;
                }
            }
        }

        private async static Task FormRestaurant()
        {
            Console.Write("Restaurant: ");
            var r = new Restaurant
            {
                Name = Console.ReadLine()
            };
            await AddRestaurant(r);
        }

        private async static Task FormPizza()
        {
            Console.Write("Pizza: ");
            var name = Console.ReadLine();
            Console.Write("RestaurantId: ");
            if (int.TryParse(Console.ReadLine(), out var id))
            {
                var p = new Pizza
                {
                    Name = name,
                    RestaurantId = id
                };
                await AddPizza(p);
            }
        }

        private async static Task Command()
        {
            foreach (var restaurant in await GetRestaurants())
            {
                Console.WriteLine($"{restaurant.Id}: {restaurant.Name}");
            }
            Console.Write("Id: ");
            if (int.TryParse(Console.ReadLine(), out var id))
            {
                foreach (var pizza in await GetPizzas(id))
                {
                    Console.WriteLine(pizza.Name);
                }
            }
        }

        private async static Task AddRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
        }

        private async static Task AddPizza(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            await _context.SaveChangesAsync();
        }

        private async static Task<List<Restaurant>> GetRestaurants()
        {
            var result = await _context.Restaurants.ToListAsync();
            return result;
        }

        private static async Task<List<Pizza>> GetPizzas(int restaurantId)
        {
            var result = await _context.Pizzas
                .Where(x => x.RestaurantId == restaurantId)
                .ToListAsync();
            return result;
        }

        private static async Task<List<Restaurant>> GetTopRestaurants()
        {
            var result = await _context.Restaurants
                .Where(x => x.Pizzas.Count >= 10)
                .ToListAsync();
            return result;
        }
    }
}
