using Bogus;
using BogusFakeAPI.Models;

namespace BogusFakeAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            var fake = new Faker<Category>()
                .RuleFor(i => i.Id, i => i.IndexFaker)
                .RuleFor(i => i.Name, i => i.Commerce.Categories(1).First());

            return fake.Generate(20);
        }
    }
}
