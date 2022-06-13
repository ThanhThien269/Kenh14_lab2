using Microsoft.AspNetCore.Mvc;
using Kenh14_client1.Models;
using Kenh14_client1.Repos;

namespace Kenh14_client1.Controllers
{
    public class ProductController : Controller
    {
        ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;
        public ProductController(IProductRepository product, ICategoryRepository _rep)
        {
            _productRepository = product;
            _categoryRepository = _rep;
        }
        public IActionResult Index()
        {
            List<Category> lst = _categoryRepository.getAllCategories();
            return View(lst);
        }
        public IActionResult Car(int id)    
        {
            Product product = _productRepository.GetProductById(id);
            return View(product);
        }
    }
}
