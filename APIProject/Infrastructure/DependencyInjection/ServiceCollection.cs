using APIProject.Persistence.Context;
using APIProject.Persistence.Repositores;
using APIProject.Persistence.Repositores.Interfaces;
using APIProject.Services;
using APIProject.Services.Interfaces;

namespace APIProject.Infrastructure.DependencyInjection
{
    public static class ServiceCollection
    {
        public static void AddScopedDI(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
