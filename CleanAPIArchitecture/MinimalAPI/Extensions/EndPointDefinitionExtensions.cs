using MinimalAPI.Endpoints;

namespace MinimalAPI.Extensions;

/// <summary>/// Class for adding endpoint definitions dynamically./// </summary>
public static class EndPointDefinitionExtensions
{
    /// <summary>  
    /// Dynamically add endpoint service definitions  
    /// </summary>  
    /// <param name="services"></param>  
    /// <param name="scanMarkers"></param>  
    public static void AddEndPointDefinitions(this IServiceCollection services, params Type[] scanMarkers)
    {
        var endpointDefinitions = new List<IEndPointDefinition>();
        foreach (var marker in scanMarkers)
        {
            endpointDefinitions
                    .AddRange(
                        marker.Assembly.ExportedTypes
                            .Where(x => typeof(IEndPointDefinition)
                            .IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract
                        )
                        .Select(Activator.CreateInstance)
                        .Cast<IEndPointDefinition>());
        }
        foreach (var endpointDefinition in endpointDefinitions)
        {
            endpointDefinition.DefineServices(services);
        }
        services.AddSingleton(endpointDefinitions as IReadOnlyCollection<IEndPointDefinition>);
    }

    /// <summary>
    ///  Dynamically add endpoint definitions 
    /// </summary>
    /// <param name="app"></param>
    public static void UseEndPointDefinitions(this WebApplication app)
    {
        var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndPointDefinition>>();
        foreach (var endpointDefinition in definitions)
        {
            endpointDefinition.DefineEndPoints(app);
        }
    }
}