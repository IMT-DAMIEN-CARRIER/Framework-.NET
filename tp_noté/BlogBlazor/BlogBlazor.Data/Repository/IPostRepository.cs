using System.Collections.Generic;
using System.Threading.Tasks;
using BlogBlazor.Data.Model;

namespace BlogBlazor.Data.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        public Task<IEnumerable<Post>> GetPostByCategory(string categoryName);
    }
}