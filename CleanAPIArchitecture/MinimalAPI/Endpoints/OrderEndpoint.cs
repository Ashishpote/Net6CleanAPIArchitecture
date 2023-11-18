

namespace MinimalAPI.Endpoints;
public class OrderEndpoint : IEndPointDefinition
{
    private ILogger<OrderEndpoint>? _logger;

    public void DefineEndPoints(WebApplication app)
    {
        app.MapGet("/orders", GetAllOrdersAsync);
        app.MapGet("/order/id", GetOrderDetailByIdAsync);
        app.MapPost("/order", AddOrderAsync);
        app.MapDelete("/order/{guid}", DeleteOrderAsync);
    }

    private Task DeleteOrderAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }

    private Task AddOrderAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }

    private Task GetAllOrdersAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }

    private Task GetOrderDetailByIdAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }

    public void DefineServices(IServiceCollection services)
    {
        //
    }
}
