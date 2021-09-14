using Pizza.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Application
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public Task<List<Domain.Pizza>> GetPizzas() => _pizzaRepository.GetPizzas();
    }
}
