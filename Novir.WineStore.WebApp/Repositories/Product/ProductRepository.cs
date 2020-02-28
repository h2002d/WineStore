using Microsoft.EntityFrameworkCore;
using Novir.WineStore.WebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Models.Product> Create(Models.Product product)
        {
            if (product.Id == 0)
                _applicationDbContext.Products.Add(product);
            else
                _applicationDbContext.Products.Update(product);
            await _applicationDbContext.SaveChangesAsync();
            return product;
        }

        public void Delete(Models.Product product)
        {
            _applicationDbContext.Products.Remove(product);
            _applicationDbContext.SaveChanges();
        }

        public async Task<Models.Product> GetProductById(int productId)
        {

            return await _applicationDbContext.Products.FindAsync(productId);
        }
        public async Task<List<Models.Product>> GetProducts()
        {
            return await _applicationDbContext.Products.ToListAsync();
        }

        public async Task<List<Models.Product>> GetProductsByCategoryId(int categoryId)
        {
            return await _applicationDbContext.Products.Where(x => x.CategoryId == categoryId).ToListAsync();
        }
    }
}
