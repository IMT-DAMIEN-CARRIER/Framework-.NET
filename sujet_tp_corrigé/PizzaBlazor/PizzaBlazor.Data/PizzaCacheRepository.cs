using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Data
{
    public class PizzaCacheRepository : IPizzaRepository
    {
        private static List<Pizza> _data = new();

        public async Task AddPizza(Pizza pizza)
        {
            pizza.Creation = DateTime.UtcNow;
            _data.Add(pizza);
        }

        public async Task<IEnumerable<Pizza>> GetPizzas()
        {
            return _data;
        }
    }
}
