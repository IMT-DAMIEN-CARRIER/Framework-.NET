using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaApi.Models;

namespace PizzaApi.Repository
{
    public interface IPizzaRepository
    {
        Task<List<Pizza>> getPizzas();
    }
}
