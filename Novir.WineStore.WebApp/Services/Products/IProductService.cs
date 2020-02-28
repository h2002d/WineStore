using Novir.WineStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Services.Products
{
    public interface IProductService
    {
        Task<Product> GetProduct(int productId);
        Task<List<Product>> GetProductsByCategoryId(int categoryId);
        Task<List<Product>> GetProducts();
        Task<Product> Create(Product product);
        void Delete(Product product);
    }
}
