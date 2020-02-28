using Novir.WineStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
