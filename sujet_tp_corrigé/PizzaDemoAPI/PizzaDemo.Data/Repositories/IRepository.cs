using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDemo.Data.Repositories
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
