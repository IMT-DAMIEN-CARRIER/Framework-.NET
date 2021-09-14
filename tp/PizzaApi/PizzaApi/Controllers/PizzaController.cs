using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaApi.Models;
using PizzaApi.Repository;

namespace PizzaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        // GET: api/Pizza
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pizza>>> GetPizzas()
        {
            var result = await _pizzaRepository.GetAll();
            
            return Ok(result);
        }

        // GET: api/Pizza/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pizza>> GetPizza(int id)
        {
            var pizza = await _pizzaRepository.GetById(id);

            if (pizza == null)
            {
                return NotFound();
            }

            return pizza;
        }

        // PUT: api/Pizza/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutPizza(int id, Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return BadRequest();
            }

            await _pizzaRepository.Update(pizza);

            return NoContent();
        }

        // POST: api/Pizza
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pizza>> PostPizza(Pizza pizza)
        {
            await _pizzaRepository.Add(pizza);

            return CreatedAtAction("GetPizza", new { id = pizza.Id }, pizza);
        }

        // DELETE: api/Pizza/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePizza(int id)
        {
            await _pizzaRepository.Delete(id);

            return NoContent();
        }
    }
}
