using BlogBlazor.Data.Model;

namespace BlogBlazor.Data.Repository
{
    public class CategoryRepository : AbstractRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MyContext context) : base(context)
        {
        }
    }
}