using Microsoft.AspNetCore.Mvc;
using Kenh14_client1.Models;
using Kenh14_client1.Repos;

namespace Kenh14_client1.Controllers
{
    public class ProductController : Controller
    {
        ICategoryRepository categoryRepository = new CategoryRepository();
        TQShopContext ctx = new TQShopContext();
        public IActionResult Index()
        {
            List<Category> lst = categoryRepository.getAllCategories();
            return View(lst);
        }
        public IActionResult Car(int id)    
        {
            Product product = ctx.Products.Where(x => x.Id == id).SingleOrDefault();
            return View(product);
        }
    }
}
