using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Novir.WineStore.WebApp.Models;
using Novir.WineStore.WebApp.Services.Products;
using Novir.WineStore.WebApp.ViewModels;

namespace Novir.WineStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var product = await _productService.GetProducts();
            return View(_mapper.Map<List<ProductViewModel>>(product));
        }

        public async Task<IActionResult> Create(int id)
        {
            var product = await _productService.GetProduct(id);
            return View(_mapper.Map<ProductViewModel>(product));
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel product)
        {
            var productNew = await _productService.Create(_mapper.Map<Product>(product));
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productService.GetProduct(id);
            _productService.Delete(product);
            return RedirectToAction("List");
        }
    }
}