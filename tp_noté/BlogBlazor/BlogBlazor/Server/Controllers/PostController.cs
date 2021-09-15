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
using BlogBlazor.Shared.Model.Post;

namespace BlogBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostController(PostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        // GET: api/Post
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            var data = await _postRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<PostReadDTO>>(data));
        }

        // GET: api/Post/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var post = _mapper.Map<PostReadDTO>(await _postRepository.GetById(id));

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        //GET : api/Post/categoryName
        [HttpGet("{categoryName}")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPostByCategory(string categoryName)
        {
            var posts = _mapper.Map<PostReadDTO>(await _postRepository.GetPostByCategory(categoryName));

            if (posts == null)
            {
                return NotFound();
            }
            
            return Ok(posts);
        }

        // PUT: api/Post/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutPost(int id, PostWriteDTO post)
        {
            var data = _mapper.Map<Post>(post);
            
            if (id != data.Id)
            {
                return BadRequest();
            }

            await _postRepository.Update(data);

            return NoContent();
        }

        // POST: api/Post
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(PostWriteDTO post)
        {
            var data = _mapper.Map<Post>(post);
            await _postRepository.Add(data);

            return CreatedAtAction("GetPost", new { id = data.Id }, data);
        }

        // DELETE: api/Post/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            if (!await _postRepository.Delete(id))
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
