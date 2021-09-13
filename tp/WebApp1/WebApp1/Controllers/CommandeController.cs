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

        // GET: Commande/Create
        public IActionResult Create()
        {
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name");
            ViewData["Pizza"] = new SelectList(_context.Pizzas, "Id", "Name");
            return View();
        }

        // POST: Commande/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Restaurant,Pizza")] Commande commande)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commande);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name");
            ViewData["Pizza"] = new SelectList(_context.Pizzas, "Id", "Name");

            return View(commande);
        }
    }
}
