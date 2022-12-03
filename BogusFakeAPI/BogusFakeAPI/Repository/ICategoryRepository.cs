using BogusFakeAPI.Models;

namespace BogusFakeAPI.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
