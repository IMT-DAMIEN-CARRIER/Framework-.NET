using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var context = new MyContext();

            var query1 = await context.People.FindAsync(7);
            var query2 = context.People.Where(x => x.LastName == "toto");

            // ADD
            var author1 = new Person { FirstName = "author1", LastName = "author1" };
            context.People.Add(author1);
            await context.SaveChangesAsync();

            // UPDATE
            query1.FirstName = "user 2";
            await context.SaveChangesAsync();

            // DELETE
            context.People.Remove(query1);
            await context .SaveChangesAsync();

            var query3 = context.Books.Where(x => x.Author.FirstName == "toto");

            var query4 = context.Books
                .Include(x => x.Author)
                .Where(x => x.Title.Contains("hello"));
        }
    }
}
