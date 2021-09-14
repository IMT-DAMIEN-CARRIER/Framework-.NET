using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaApi.Models;

namespace PizzaApi.Repository
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly MyContext _context;

        public PizzaRepository(MyContext context)
        {
            _context = context;
        }

        public Task<List<Pizza>> getPizzas()
        {
            throw new NotImplementedException();
        }
    }
}
