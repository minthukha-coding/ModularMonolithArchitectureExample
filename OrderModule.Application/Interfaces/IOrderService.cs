namespace OrderModule.Application.Interfaces;

public interface IOrderService
{
    Task<string> GetOrder();
}