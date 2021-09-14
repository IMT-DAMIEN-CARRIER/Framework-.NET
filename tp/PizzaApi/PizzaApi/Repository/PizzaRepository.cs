using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaApi.Models;

namespace PizzaApi.Repository
{
    public class PizzaRepository : AbstractRepository<Pizza>, IPizzaRepository
    {
        public PizzaRepository(MyContext context) : base(context)
        {
        }
    }
}
