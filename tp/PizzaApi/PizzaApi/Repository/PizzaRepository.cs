using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task Add(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            await _context.SaveChangesAsync(); 
        }

        public async Task Update(Pizza pizza)
        {
            _context.Entry(pizza).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Pizza pizza)
        {
            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pizza>> GetAll()
        {
            return await _context.Pizzas.ToListAsync();
        }

        public async Task<Pizza> GetById(int id)
        {
            return await _context.Pizzas.FindAsync(id);
        }
    }
}
