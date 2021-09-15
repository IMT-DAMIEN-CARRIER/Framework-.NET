using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories
{
    public interface IRepository<T>
    {
        Task Add(T item);
        Task Update(T item);
        Task<bool> Delete(Int64 id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Int64 id);
    }
}
