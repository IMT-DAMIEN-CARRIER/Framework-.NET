using Microsoft.EntityFrameworkCore;
using PizzaDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDemo.Data.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(MyContext context) 
            : base(context)
        {
        }

        public async Task<IEnumerable<Restaurant>> GetTopRestaurants()
        {
            return await _context.Restaurants.Where(x => x.Pizzas.Count > 10)
                .ToListAsync();
        }
    }
}
