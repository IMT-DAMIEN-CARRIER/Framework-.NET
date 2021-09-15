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

        public async Task<Author> GetAuthorByEmail(string email, string password)
        {
            return await Context.Authors
                .Where(a => a.Email.Equals(email) && a.Password.Equals(password))
                .FirstOrDefaultAsync();
        }
    }
}