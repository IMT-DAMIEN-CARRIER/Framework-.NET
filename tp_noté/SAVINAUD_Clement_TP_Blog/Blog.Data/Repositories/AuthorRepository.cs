using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Models;

namespace Blog.Data.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {

        public AuthorRepository(MyContext context)
            : base(context)
        {
        }

        public async Task<Author> GetAuthorByEmailPassword(Author author)
        {
            return await _context.Author.Include(a => a.Posts).FirstOrDefaultAsync(a => a.Email == author.Email && a.Password == author.Password);
        }
    }
}
