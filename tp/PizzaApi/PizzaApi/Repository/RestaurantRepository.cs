using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaApi.Models;

namespace PizzaApi.Repository
{
    public class RestaurantRepository : AbstractRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(MyContext context) : base(context)
        {
        }
    }
}
