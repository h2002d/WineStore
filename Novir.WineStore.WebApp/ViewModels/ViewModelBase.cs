using Novir.WineStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.ViewModels
{
    public class ViewModelBase
    {
        public List<Category> Categories
        {
            get
            {
                //need to be changed
                var cat1 = new Category();
                cat1.Name = "Category1";
                cat1.Id = 1;
                List<Category> cat = new List<Category> { cat1, cat1, cat1 };
                return cat;
            }
        }
    }
}
