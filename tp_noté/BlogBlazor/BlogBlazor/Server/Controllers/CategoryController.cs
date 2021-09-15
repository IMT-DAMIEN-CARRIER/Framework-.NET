using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BlogBlazor.Data.Model;
using BlogBlazor.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using BlogBlazor.Shared.Model.Category;

namespace BlogBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return Ok(_mapper.Map<IEnumerable<CategoryReadDTO>>(await _categoryRepository.GetAll()));
        }

        // GET: api/Category/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = _mapper.Map<CategoryReadDTO>(await _categoryRepository.GetById(id));

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // PUT: api/Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutCategory(int id, CategoryWriteDTO category)
        {
            var data = _mapper.Map<Category>(category);
            
            if (id != data.Id)
            {
                return BadRequest();
            }

            await _categoryRepository.Update(data);

            return NoContent();
        }

        // POST: api/Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(CategoryWriteDTO category)
        {
            var data = _mapper.Map<Category>(category);
            await _categoryRepository.Add(data);

            return CreatedAtAction("GetCategory", new { id = data.Id }, data);
        }
    }
}
