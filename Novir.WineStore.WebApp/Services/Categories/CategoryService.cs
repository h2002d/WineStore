using Novir.WineStore.WebApp.Models;
using Novir.WineStore.WebApp.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryService;

        public CategoryService(ICategoryRepository categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<Category> Create(Category category)
        {
            return await _categoryService.Create(category);
        }

        public void Delete(Category category)
        {
            _categoryService.Delete(category);
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _categoryService.GetCategories();
        }

        public async Task<Category> GetCategory(int categoryId)
        {
            return await _categoryService.GetCategory(categoryId);
        }
    }
}
