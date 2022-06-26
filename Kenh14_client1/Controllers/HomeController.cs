using Kenh14_client1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kenh14_client1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        TQShopContext context= new TQShopContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            Customer contact = new Customer();
            return View(contact);
        }
        [HttpPost]
        public IActionResult Contact(Customer contact)
        {
            if(ModelState.IsValid){
                Customer c = context.Customers.Where(x => x.Address == contact.Address).SingleOrDefault();
                if(c != null)
                {
                    ModelState.AddModelError(string.Empty, "Email nay da dang ky");
                    return View(contact);
                }
                context.Customers.Add(contact);
                context.SaveChanges();
                return RedirectToAction("contact");
            }
            else { 
            return View(contact);
            }
           
        }
        //public IActionResult Car()
        //{
        //    CarRepos repos = new CarRepos();
        //    List<Car> cars = repos.getAllCar();
        //    return View(cars);
        //}
        public IActionResult Privacy()
        {
            CarRepos rep= new CarRepos();
            List<Car> cars= rep.getAllCar();
            return View(cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}