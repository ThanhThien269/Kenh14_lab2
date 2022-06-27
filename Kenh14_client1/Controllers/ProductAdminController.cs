using Microsoft.AspNetCore.Mvc;
using Kenh14_client1.Repos;
using Kenh14_client1.Models;

namespace Kenh14_client1.Controllers
{
    public class ProductAdminController : Controller
    {
        ICategoryRepository _categoryRepository;   
        private IProductRepository _productRepository;
        public ProductAdminController(IProductRepository product, ICategoryRepository _rep)
        {
            _productRepository = product;
            _categoryRepository = _rep;
        }
        public IActionResult Index()
        {
            ViewBag.DSSP = _productRepository.GetAllProducts();
            return View();
        }
        [HttpGet]
        public IActionResult Product()
        {
            Product item = new Product();
            // categories ==> dropdownlist
            ViewBag.categories = _categoryRepository.getAllCategories();
            return View(item);
        }
        [HttpPost]
        public IActionResult Product(Product i)
        {
            _productRepository.AddProduct(i);
            return RedirectToAction("Index");

        }
    }
}
