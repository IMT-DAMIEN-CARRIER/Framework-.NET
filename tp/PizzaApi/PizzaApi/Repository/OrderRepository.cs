using System;
using PizzaApi.Models;

namespace PizzaApi.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MyContext _context;

        public OrderRepository(MyContext context)
        {
            _context = context;
        }
    }
}
