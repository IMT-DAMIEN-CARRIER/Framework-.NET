using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : class
    {
        protected readonly MyContext _context;

        public BaseRepository(MyContext context)
        {
            _context = context;
        }

        public async Task Add(T item)
        {
            _context.Set<T>().Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(Int64 id)
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

        public async Task<T> GetById(Int64 id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
