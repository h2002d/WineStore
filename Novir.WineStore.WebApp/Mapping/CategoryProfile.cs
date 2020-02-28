using AutoMapper;
using Novir.WineStore.WebApp.Models;
using Novir.WineStore.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category,CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
