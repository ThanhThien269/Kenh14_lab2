using Kenh14_client1.Models;

namespace Kenh14_client1.Repos
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCategoryId(int id);
        Product GetProductById(int id);
        bool AddProduct(Product product);
    }
}
