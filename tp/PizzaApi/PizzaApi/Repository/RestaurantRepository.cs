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

        public async Task Add(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Restaurant>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Restaurant> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
