using Novir.WineStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Services.Categories
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(int categoryId);
        Task<Category> Create(Category category);
        void Delete(Category category);
    }
}
