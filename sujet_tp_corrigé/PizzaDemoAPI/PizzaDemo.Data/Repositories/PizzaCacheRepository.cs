using PizzaDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDemo.Data.Repositories
{
    public class PizzaCacheRepository : IPizzaRepository
    {
        private static List<Pizza> _pizzas = new();

        public Task Add(Pizza item)
        {
            _pizzas.Add(item);
            return Task.FromResult(0);
        }

        public async Task<bool> Delete(int id)
        {
            var pizza = _pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null) return false;
            _pizzas.Remove(pizza);
            return true;
        }

        public async Task<IEnumerable<Pizza>> GetAll()
        {
            return _pizzas;
        }

        public async Task<Pizza> GetById(int id)
        {
            return _pizzas.FirstOrDefault(x => x.Id == id);
        }

        public async Task Update(Pizza item)
        {
            var pizza = await GetById(item.Id);
            var index = _pizzas.IndexOf(pizza);
            _pizzas[index] = item;
        }
    }
}
