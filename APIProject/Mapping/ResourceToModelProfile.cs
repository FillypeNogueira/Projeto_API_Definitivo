using APIProject.Domain.Models;
using APIProject.Resources;
using AutoMapper;

namespace APIProject.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        { 
            CreateMap<ProductResource, Product>();
            CreateMap<CategoryResource, Category>();
        }
    }
}
