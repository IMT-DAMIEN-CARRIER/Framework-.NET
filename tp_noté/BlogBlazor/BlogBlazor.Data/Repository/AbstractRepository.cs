using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlogBlazor.Data.Repository
{
    public abstract class AbstractRepository<T> : IRepository<T>
        where T: class
    {
        protected readonly MyContext Context;

        public AbstractRepository(MyContext context)
        {
            Context = context;
        }

        public async Task Add(T item)
        {
            Context.Set<T>().Add(item);
            await Context.SaveChangesAsync(); 
        }

        public async Task Update(T item)
        {
            Context.Entry(item).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var item = await Context.Set<T>().FindAsync(id);

            if (item == null)
            {
                return false;
            }
            
            Context.Set<T>().Remove(item);
            await Context.SaveChangesAsync();
            
            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        }
    }
}