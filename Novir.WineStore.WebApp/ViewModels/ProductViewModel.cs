using Microsoft.AspNetCore.Http;
using Novir.WineStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainImagePath { get; set; }
        public IFormFile MainImageFile { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public List<ProductImages> ProductImages { get; set; }
        public List<IFormFile> ProductImageFiles { get; set; }
    }
}
