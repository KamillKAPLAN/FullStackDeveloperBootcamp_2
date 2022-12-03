using Bogus;
using BogusFakeAPI.Models;

namespace BogusFakeAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            /*var faker = new Faker("tr");
            var product = new Product()
            {
                Id = faker.Random.Number(1, 100),
                Name = faker.Commerce.ProductName(),
                Category = faker.Commerce.Categories(1).First(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Commerce.Price(5, 100, 2).First(),
                PictureUri = faker.Image.Technics(100, 100)                
            };*/

            var faker = new Faker<Product>("tr")
                .RuleFor(i => i.Id, i => i.IndexFaker)
                .RuleFor(i => i.Name, i => i.Commerce.ProductName())
                .RuleFor(i => i.CategoryId, i => i.Random.Number(1, 20))
                .RuleFor(i => i.Description, i => i.Commerce.ProductDescription())
                .RuleFor(i => i.Price, i => i.Commerce.Price(5, 100, 2).First())
                .RuleFor(i => i.PictureUri, i => i.Image.PicsumUrl());
            return faker.Generate(100);
        }
    }
}
