using Novir.WineStore.WebApp.Models;
using Novir.WineStore.WebApp.Repositories.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProduct(int productId)
        {
            return await _productRepository.GetProductById(productId);
        }

        public async Task<List<Product>> GetProducts()
        {
           return await _productRepository.GetProducts();
        }

        public async Task<List<Product>> GetProductsByCategoryId(int categoryId)
        {
            return await _productRepository.GetProductsByCategoryId(categoryId);
        }

        public async Task<Product> Create(Product product)
        {
            return await _productRepository.Create(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }
    }
}
