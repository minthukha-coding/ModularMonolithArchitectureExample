using ProductModule.Application.Interfaces;
using ProductModule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
