using PizzaDemo.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaDemo.Data.Repositories
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<IEnumerable<Restaurant>> GetTopRestaurants();
    }
}
