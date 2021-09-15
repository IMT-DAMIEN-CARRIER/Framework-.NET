using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BlogBlazor.Data.Model;
using BlogBlazor.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using BlogBlazor.Shared.Model.Post;

namespace BlogBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        // GET: api/Post
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return Ok(_mapper.Map<IEnumerable<PostReadDTO>>(await _postRepository.GetAll()));
        }
        
        //GET : api/Post/categoryName
        [HttpGet("{categoryName}")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPostByCategory(string categoryName)
        {
            return Ok(_mapper.Map<IEnumerable<PostReadDTO>>(await _postRepository.GetPostByCategory(categoryName)));
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
