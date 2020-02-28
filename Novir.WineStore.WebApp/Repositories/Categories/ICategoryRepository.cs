using Novir.WineStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task<Category> Create(Category category);
        void Delete(Category category);
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(int categoryId);
    }
}
