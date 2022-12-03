using BogusFakeAPI.Models;

namespace BogusFakeAPI.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
