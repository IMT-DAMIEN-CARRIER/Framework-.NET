using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlogBlazor.Data.Repository
{
    public class AbstractRepository<T> : IRepository<T>
        where T: class
    {
        private readonly MyContext _context;

        public AbstractRepository(MyContext context)
        {
            _context = context;
        }

        public async Task Add(T item)
        {
            _context.Set<T>().Add(item);
            await _context.SaveChangesAsync(); 
        }

        public async Task Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var item = await _context.Set<T>().FindAsync(id);

            if (item == null)
            {
                return false;
            }
            
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
            
            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}