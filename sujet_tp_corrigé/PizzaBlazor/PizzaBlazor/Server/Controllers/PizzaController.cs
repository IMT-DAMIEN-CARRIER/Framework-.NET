using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBlazor.Data;
using PizzaBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaController(IMapper mapper, IPizzaRepository pizzaRepository)
        {
            this._mapper = mapper;
            this._pizzaRepository = pizzaRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<PizzaReadDTO>> Get()
        {
            var data = await _pizzaRepository.GetPizzas();
            return _mapper.Map<IEnumerable<PizzaReadDTO>>(data);
        }

        [HttpPost]
        public async Task<ActionResult> Post(PizzaWriteDTO pizza)
        {
            var data = _mapper.Map<Pizza>(pizza);
            await _pizzaRepository.AddPizza(data);
            return Created("", pizza);
        }

    }
}
