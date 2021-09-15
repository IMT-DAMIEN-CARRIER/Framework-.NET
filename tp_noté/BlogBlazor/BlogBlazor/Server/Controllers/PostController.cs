using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogBlazor.Data;
using BlogBlazor.Data.Model;
using BlogBlazor.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogBlazor.Shared.Model;

namespace BlogBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostRepository _postRepository;

        public PostController(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // GET: api/Post
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return Ok(await _postRepository.GetAll());
        }

        // GET: api/Post/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var post = await _postRepository.GetById(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        //GET : api/Post/categoryName
        [HttpGet("{categoryName}")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPostByCategory(string categoryName)
        {
            var posts = await _postRepository.GetPostByCategory(categoryName);

            if (posts == null)
            {
                return NotFound();
            }
            
            return Ok(posts);
        }

        // PUT: api/Post/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutPost(int id, Post post)
        {
            if (id != post.Id)
            {
                return BadRequest();
            }

            await _postRepository.Update(post);

            return NoContent();
        }

        // POST: api/Post
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            await _postRepository.Add(post);

            return CreatedAtAction("GetPost", new { id = post.Id }, post);
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
