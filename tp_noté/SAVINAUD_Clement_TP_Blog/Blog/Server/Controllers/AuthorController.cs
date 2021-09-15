using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data.Models;
using Blog.Data.Repositories;
using Blog.Shared.DTO;

namespace Blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IMapper mapper, IAuthorRepository authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }

        // GET: api/author
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorReadDTO>>> GetAll()
        {
            var result = await _authorRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<AuthorReadDTO>>(result));
        }

        // GET: api/author/1
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorReadDTO>> Get(int id)
        {
            var author = await _authorRepository.GetById(id);

            if (author == null)
            {
                return NotFound();
            }

            return _mapper.Map<AuthorReadDTO>(author);
        }

        // POST: api/author
        [HttpPost]
        public async Task<ActionResult<AuthorReadDTO>> Post(AuthorWriteDTO authorDTO)
        {
            Author author = _mapper.Map<Author>(authorDTO);
            await _authorRepository.Add(author);
            return CreatedAtAction("Get", new { id = author.Id }, _mapper.Map<AuthorReadDTO>(_mapper.Map<Author>(author)));
        }

        // GET: api/author/authentication
        [HttpPost("authenticate")]
        public async Task<ActionResult<AuthorReadDTO>> AuthenticateAuthor(AuthorLoginDTO author)
        {
            var data = _mapper.Map<Author>(author);
            var readData = _mapper.Map<AuthorReadDTO>(await _authorRepository.GetAuthorByEmailPassword(data));
            return CreatedAtAction("Get", new { id = data.Id }, _mapper.Map<AuthorReadDTO>(_mapper.Map<Author>(readData)));
        }
    }
}
