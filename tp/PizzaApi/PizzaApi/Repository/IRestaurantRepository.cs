using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaApi.Models;

namespace PizzaApi.Repository
{
    public interface IRestaurantRepository
    {
        Task<List<Restaurant>> GetRestaurants();
    }
}
