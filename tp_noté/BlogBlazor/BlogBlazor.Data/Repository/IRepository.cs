using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogBlazor.Data.Repository
{
    public interface IRepository<T>
    {
        Task Add(T item);
        Task Update(T item);
        Task<bool> Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
    }
}