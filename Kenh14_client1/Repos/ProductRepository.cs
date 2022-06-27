using Kenh14_client1.Models;
using Microsoft.EntityFrameworkCore;

namespace Kenh14_client1.Repos
{
    public class ProductRepository : IProductRepository
    {
        private TQShopContext _shopContext;
        public ProductRepository(TQShopContext ctx)
        {
            _shopContext = ctx;
        }
        public List<Product> GetAllProducts()
        {
            return _shopContext.Products.Include(x=>x.Category).ToList() ;
        }

        public Product GetProductById(int id)
        {
            return _shopContext.Products.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(Product product)
        {
            try
            {
                _shopContext.Products.Add(product);
                _shopContext.SaveChanges();
                return true;
            }catch
            {
                return false;
            }
            
        }
    }
}
