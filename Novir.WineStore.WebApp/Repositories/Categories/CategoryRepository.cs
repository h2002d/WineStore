using Microsoft.EntityFrameworkCore;
using Novir.WineStore.WebApp.Data;
using Novir.WineStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Category> Create(Category category)
        {
            if (category.Id == 0)
                await _applicationDbContext.Categories.AddAsync(category);
            else
                _applicationDbContext.Categories.Update(category);
            await _applicationDbContext.SaveChangesAsync();
            return category;
        }

        public void Delete(Category category)
        {
            _applicationDbContext.Categories.Remove(category);
            _applicationDbContext.SaveChanges();
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _applicationDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategory(int categoryId)
        {
            return await _applicationDbContext.Categories.FindAsync(categoryId);
        }
    }
}
