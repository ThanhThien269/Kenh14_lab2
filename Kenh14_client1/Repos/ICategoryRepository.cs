using System.Collections.Generic;
using Kenh14_client1.Models;

namespace Kenh14_client1.Repos
{
    public interface ICategoryRepository
    {
     List<Category>  getAllCategories();
    }
}
