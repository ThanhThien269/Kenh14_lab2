using Kenh14_client1.Models;
using Microsoft.EntityFrameworkCore;

namespace Kenh14_client1.Repos
{
    public class CategoryRepository : ICategoryRepository
    {
        TQShopContext ctx;
        public CategoryRepository(TQShopContext _ctx)
        {
            ctx = _ctx;
        }
        public List<Category> getAllCategories()
        {
            return ctx.Categories.Include(x=>x.Products).ToList();
        }
    }
}
