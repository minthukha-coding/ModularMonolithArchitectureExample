using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderModule.Application.Interfaces;

namespace OrderModule.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrder()
    {
        return Ok(_orderService.GetOrder());
    }
}