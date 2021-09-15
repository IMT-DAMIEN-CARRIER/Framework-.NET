using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Domain
{
    public interface IPizzaRepository
    {
        Task<List<Pizza>> GetPizzas();
    }
}
