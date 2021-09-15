using Microsoft.AspNetCore.Mvc;
using PizzaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWeb.Controllers
{
    public class OrderController : Controller
    {
        private readonly PizzaContext _context;

        public OrderController(PizzaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Buy(int? id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null)
                return NotFound();

            var order = new Order
            {
                Pizza = pizza,
                PizzaId = pizza.Id
            };
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Buy(Order order)
        {
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PizzasController.Index), "Pizzas");
        }
    }
}
