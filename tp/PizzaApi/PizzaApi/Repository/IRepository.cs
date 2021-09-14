using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaApi.Repository
{
    public interface IRepository<T>
    {
        Task Add(T item);
        Task Update(T item);
        Task Delete(T item);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
    }
}