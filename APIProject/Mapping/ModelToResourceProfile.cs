using APIProject.Domain.Models;
using APIProject.Resources;
using AutoMapper;

namespace APIProject.Mapping
{
    public class ModelToResourceProfile: Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Product, ProductResource>();
            CreateMap<Category, CategoryResource>();
        }
    }
}
