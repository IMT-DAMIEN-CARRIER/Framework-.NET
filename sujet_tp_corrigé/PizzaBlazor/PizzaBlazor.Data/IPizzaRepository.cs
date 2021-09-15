using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Data
{
    public interface IPizzaRepository
    {
        Task<IEnumerable<Pizza>> GetPizzas();
        Task AddPizza(Pizza pizza);
    }
}
