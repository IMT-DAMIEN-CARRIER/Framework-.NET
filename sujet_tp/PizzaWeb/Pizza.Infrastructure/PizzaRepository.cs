using Microsoft.EntityFrameworkCore;
using Pizza.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Infrastructure
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly PizzaContext _context;

        public PizzaRepository(PizzaContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Pizza>> GetPizzas()
        {
            return await _context.Pizzas.ToListAsync();
        }
    }
}
