using AutoMapper;
using Blog.Data.Models;
using Blog.Data.Repositories;
using Blog.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        // GET: api/category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryReadDTO>>> GetAll()
        {
            var result = await _categoryRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<CategoryReadDTO>>(result));
        }

        // GET: api/category/1
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryReadDTO>> Get(Int64 id)
        {
            var category = await _categoryRepository.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            return _mapper.Map<CategoryReadDTO>(category);
        }

        // POST: api/category
        [HttpPost]
        public async Task<ActionResult<CategoryReadDTO>> Post(CategoryWriteDTO categoryDTO)
        {
            Category category = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Add(category);
            return CreatedAtAction("Get", new { id = category.Id }, _mapper.Map<CategoryReadDTO>(category));
        }

        // DELETE: api/category/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Int64 id)
        {
            if (!await _categoryRepository.Delete(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // PUT: api/category/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(Int64 id, CategoryWriteDTO categoryDTO)
        {
            Category category = await _categoryRepository.GetById(id);
            category.Name = categoryDTO.Name;
            if (id != category.Id)
            {
                return BadRequest();
            }

            await _categoryRepository.Update(category);

            return NoContent();
        }
    }
}
