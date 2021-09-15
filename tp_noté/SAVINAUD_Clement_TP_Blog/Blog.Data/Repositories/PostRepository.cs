using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(MyContext context)
            : base(context)
        {
        }

        public new async Task<IEnumerable<Post>> GetAll()
        {
            return await _context.Post.Include(x => x.Category).Include(x => x.Author).Where(x => x.Date <= DateTime.UtcNow).OrderByDescending(x => x.Date).ToListAsync();
        }

        public new async Task<Post> GetById(Int64 id)
        {
            return await _context.Post.Include(x => x.Category).Include(x => x.Author).Where(x => x.Id == id && x.Date <= DateTime.UtcNow).OrderByDescending(x => x.Date).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Post>> GetPostFilteredByCategory(string categoryName)
        {
            return await _context.Post.Include(x => x.Category).Include(x => x.Author).Where(x => x.Category.Name == categoryName && x.Date <= DateTime.UtcNow).OrderByDescending(x => x.Date).ToListAsync();
        }
    }
}
