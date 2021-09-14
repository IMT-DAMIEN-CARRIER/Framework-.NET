using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaApi.Models;

namespace PizzaApi.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly MyContext _context;

        public RestaurantRepository(MyContext context)
        {
            _context = context;
        }

        public Task<List<Restaurant>> GetRestaurants()
        {
            throw new NotImplementedException();
        }
    }
}
