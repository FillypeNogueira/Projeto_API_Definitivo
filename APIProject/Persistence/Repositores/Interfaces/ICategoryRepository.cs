using APIProject.Domain.Models;

namespace APIProject.Persistence.Repositores.Interfaces
{
    public interface ICategoryRepository
    {
        Task AddAsync(Category category);

        Task Update(Category category);

        Task<Category?> GetCategoryByIdAsync(long id);

        Task DeleteCategory(Category product);

        Task<IEnumerable<Category>> FindCategoriesByParamsAsync(string? name = null, bool status = true);

        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}