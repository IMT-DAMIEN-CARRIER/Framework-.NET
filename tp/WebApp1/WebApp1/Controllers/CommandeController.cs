using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class CommandeController : Controller
    {
        private readonly PizzaContext _context;

        public CommandeController(PizzaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Buy(int? id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);

            if (null == pizza)
            {
                return NotFound();
            }

            var order = new Commande
            {
                Pizza = pizza,
                PizzaId = pizza.Id
            };

            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Buy(Commande commande)
        {
            _context.Commandes.Add(commande);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(PizzaController.Index), "Pizzas");
        }
    }
}
