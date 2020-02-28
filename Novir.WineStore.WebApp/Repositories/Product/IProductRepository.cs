using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Repositories.Product
{
    public interface IProductRepository
    {
        Task<Models.Product> GetProductById(int productId);
        Task<List<Models.Product>> GetProductsByCategoryId(int categoryId);
        Task<List<Models.Product>> GetProducts();
        Task<Models.Product> Create(Models.Product product);
        void Delete(Models.Product product);
    }
}
