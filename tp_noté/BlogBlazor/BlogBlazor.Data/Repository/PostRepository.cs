using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlogBlazor.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogBlazor.Data.Repository
{
    public class PostRepository : AbstractRepository<Post>, IPostRepository
    {
        public PostRepository(MyContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Post>> GetPostByCategory(string categoryName)
        {
            return await Context.Posts
                .Include(a => a.Author)
                .Include(c => c.Category)
                .Where(p => p.Category.Name.Equals(categoryName))
                .ToListAsync();
        }
        
        public new async Task<IEnumerable<Post>> GetAll()
        {
            return await Context.Posts
                .Include(a => a.Author)
                .Include(c => c.Category)
                .ToListAsync();
        }
        
        public new async Task<Post> GetById(int id)
        {
            return await Context.Posts
                .Include(a => a.Author)
                .Include(c => c.Category)
                .Where(p => p.Id.Equals(id))
                .FirstOrDefaultAsync();
        }
    }
}