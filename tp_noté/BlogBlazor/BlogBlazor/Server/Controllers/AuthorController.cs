using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogBlazor.Data;
using BlogBlazor.Data.Model;
using BlogBlazor.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogBlazor.Shared.Model;
using BlogBlazor.Shared.Model.Author;

namespace BlogBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        // GET: api/Author
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return Ok(_mapper.Map<IEnumerable<AuthorReadDTO>>(await _authorRepository.GetAll()));
        }

        // GET: api/Author/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            var author = _mapper.Map<AuthorReadDTO>(await _authorRepository.GetById(id));

            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }
        
        // GET: api/Author/email/password
        [HttpGet("{email, password}")]
        public async Task<ActionResult<Author>> GetAuthorByLogin(string email, string password)
        {
            var author = _mapper.Map<AuthorReadDTO>(await _authorRepository.GetAuthorByEmail(email, password));

            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }

        // PUT: api/Author/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutAuthor(int id, AuthorWriteDTO author)
        {
            var data = _mapper.Map<Author>(author);
            
            if (id != data.Id)
            {
                return BadRequest();
            }

            await _authorRepository.Update(data);

            return NoContent();
        }

        // POST: api/Author
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(AuthorWriteDTO author)
        {
            var data = _mapper.Map<Author>(author);
            await _authorRepository.Add(data);

            return CreatedAtAction("GetAuthor", new { id = data.Id }, data);
        }

        // DELETE: api/Author/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            if (!await _authorRepository.Delete(id))
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
