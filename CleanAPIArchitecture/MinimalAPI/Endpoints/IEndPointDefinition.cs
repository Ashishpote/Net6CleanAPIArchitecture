namespace MinimalAPI.Endpoints;

/// <summary>
/// Contract for EndPoint definitions
/// </summary>
public interface IEndPointDefinition
{
    /// <summary>
    /// define services
    /// </summary>
    /// <param name="services"></param>
    void DefineServices(IServiceCollection services);

    /// <summary>
    /// define endpoints
    /// </summary>
    /// <param name="app"></param>
    void DefineEndPoints(WebApplication app);

}

