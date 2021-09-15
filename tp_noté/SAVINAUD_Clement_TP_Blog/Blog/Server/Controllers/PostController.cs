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
    public class PostController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;

        public PostController(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }

        // GET: api/post
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostReadDTO>>> GetAll()
        {
            var result = await _postRepository.GetAll();
            return Ok(_mapper.Map< IEnumerable<PostReadDTO>>(result));
        }

        // GET: api/post/1
        [HttpGet("{id}")]
        public async Task<ActionResult<PostReadDTO>> Get(Int64 id)
        {
            var post = await _postRepository.GetById(id);

            if (post == null)
            {
                return NotFound();
            }

            return _mapper.Map<PostReadDTO>(post);
        }

        // POST: api/post
        [HttpPost]
        public async Task<ActionResult<PostReadDTO>> Post(PostWriteDTO postDTO)
        {
            Post post = _mapper.Map<Post>(postDTO);
            await _postRepository.Add(post);
            return CreatedAtAction("Get", new { id = post.Id }, _mapper.Map<PostReadDTO>(_mapper.Map<Post>(post)));
        }

        // DELETE: api/post/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(Int64 id)
        {
            if (!await _postRepository.Delete(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // PUT: api/post/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(Int64 id, PostWriteDTO postDTO)
        {
            Post post = await _postRepository.GetById(id);
            if (id != post.Id)
            {
                return BadRequest();
            }
            post.Name = postDTO.Name;
            post.Description = postDTO.Description;
            post.Date = postDTO.Date;
            post.Content = postDTO.Content;
            post.CategoryId = postDTO.CategoryId;
            post.AuthorId = postDTO.AuthorId;

            await _postRepository.Update(post);

            return NoContent();
        }

        // GET: api/post/filter/category
        [HttpGet("filter/{categoryName}")]
        public async Task<IEnumerable<PostReadDTO>> GetPostByCategory(string categoryName)
        {
            return _mapper.Map<IEnumerable<PostReadDTO>>(await _postRepository.GetPostFilteredByCategory(categoryName));
        }
    }
}
