using Microsoft.AspNetCore.Mvc;
using ProductModule.Application.Interfaces;

namespace ProductModule.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_productService.GetAll());
    }
}