using ProductModule.Application.Interfaces;
using ProductModule.Domain.Entities;

namespace ProductModule.Application.Services;

public class ProductService : IProductService
{
    public IEnumerable<Product> GetAll()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Keyboard" },
            new Product { Id = 2, Name = "Mouse" }
        };
    }
}