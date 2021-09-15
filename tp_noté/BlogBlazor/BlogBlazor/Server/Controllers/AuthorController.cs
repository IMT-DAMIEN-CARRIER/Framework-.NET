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
        
        // POST: api/Author/Auth
        [HttpPost("auth")]
        public async Task<ActionResult<AuthorReadDTO>> GetAuthorByLogin(AuthorLoginReadDTO author)
        {
            var data = _mapper.Map<AuthorReadDTO>(
                await _authorRepository.GetAuthorByEmail(
                    author.Email, author.Password
                    )
                );

            if (data == null)
            {
                return NotFound();
            }

            return CreatedAtAction("GetAuthor", new { id = data.Id }, _mapper.Map<AuthorReadDTO>(_mapper.Map<Author>(data)));
        }

        // POST: api/Author
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(AuthorWriteDTO authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            await _authorRepository.Add(author);

            return CreatedAtAction("GetAuthor", new { id = author.Id }, _mapper.Map<AuthorReadDTO>(_mapper.Map<Author>(author)));
        }
    }
}
