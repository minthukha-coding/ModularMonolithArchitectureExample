using OrderModule.Application.Interfaces;

namespace OrderModule.Application.Services;

public class OrderService : IOrderService
{
    public async Task<string> GetOrder()
    {
        return "Order";
    }
}
