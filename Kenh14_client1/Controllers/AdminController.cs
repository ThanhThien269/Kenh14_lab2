using Kenh14_client1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kenh14_client1.Controllers
{
    public class AdminController : Controller
    {
        TQShopContext ctx = new TQShopContext();
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult AllProduct()
        {
            List<Product> products = ctx.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ctx.Products.Add(p);
            ctx.SaveChanges();
            //lam moi giao dien

            return RedirectToAction("AllProduct");

        }

        public IActionResult DeleteProduct(int id)
        {
            Product pd = ctx.Products.Where(x => x.Id == id).SingleOrDefault();
            if(pd != null)
            {
                ctx.Products.Remove(pd);
                ctx.SaveChanges();
            }
            
            
            return RedirectToAction("AllProduct");
        }


    }
}
