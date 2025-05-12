using ProductModule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModule.Application.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetAll();
}