using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Application
{
    public interface IPizzaService
    {
        Task<List<Domain.Pizza>> GetPizzas();
    }
}
