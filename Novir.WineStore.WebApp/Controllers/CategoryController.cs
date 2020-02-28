using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Novir.WineStore.WebApp.Models;
using Novir.WineStore.WebApp.Services.Categories;
using Novir.WineStore.WebApp.ViewModels;

namespace Novir.WineStore.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var category = await _categoryService.GetCategories();
            return View(_mapper.Map<List<CategoryViewModel>>(category));
        }

        public async Task<IActionResult> Create(int id)
        {
            var category = await _categoryService.GetCategory(id);
            return View(_mapper.Map<CategoryViewModel>(category));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel category)
        {
            var categoryNew = await _categoryService.Create(_mapper.Map<Category>(category));
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _categoryService.GetCategory(id);
            _categoryService.Delete(product);
            return RedirectToAction("List");
        }
    }
}