using System.Collections.Generic;
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
            return await Context.Posts.Where(p => p.Category.Name.Equals(categoryName)).ToListAsync();
        }
    }
}