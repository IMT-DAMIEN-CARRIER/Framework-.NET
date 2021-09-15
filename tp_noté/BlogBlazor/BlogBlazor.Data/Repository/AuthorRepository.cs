using System.Linq;
using System.Threading.Tasks;
using BlogBlazor.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogBlazor.Data.Repository
{
    public class AuthorRepository : AbstractRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyContext context) : base(context)
        {
        }

        public async Task<Author> GetAuthorByEmail(string email)
        {
            return await Context.Authors.Where(a => a.Email.Equals(email)).FirstOrDefaultAsync();
        }
    }
}