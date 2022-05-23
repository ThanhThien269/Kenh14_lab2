using Kenh14_client1.Models;
using Microsoft.EntityFrameworkCore;

namespace Kenh14_client1.Repos
{
    public class CategoryRepository : ICategoryRepository
    {
        TQShopContext ctx = new TQShopContext();
        public List<Category> getAllCategories()
        {
            return ctx.Categories.Include(x=>x.Products).ToList();
        }
    }
}
