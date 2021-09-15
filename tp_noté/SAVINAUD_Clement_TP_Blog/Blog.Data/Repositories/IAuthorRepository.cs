using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Models;

namespace Blog.Data.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetAuthorByEmailPassword(Author author);
    }
}
