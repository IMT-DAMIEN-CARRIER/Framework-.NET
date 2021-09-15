using System.Threading.Tasks;
using BlogBlazor.Data.Model;

namespace BlogBlazor.Data.Repository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        public Task<Author> GetAuthorByEmail(string email);
    }
}