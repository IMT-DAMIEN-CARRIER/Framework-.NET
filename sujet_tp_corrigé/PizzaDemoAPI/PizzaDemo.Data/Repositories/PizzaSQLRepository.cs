using Microsoft.EntityFrameworkCore;
using PizzaDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDemo.Data.Repositories
{
    public class PizzaSQLRepository : BaseRepository<Pizza>, IPizzaRepository
    {
        public PizzaSQLRepository(MyContext context)
            : base(context)
        { }
    }
}
