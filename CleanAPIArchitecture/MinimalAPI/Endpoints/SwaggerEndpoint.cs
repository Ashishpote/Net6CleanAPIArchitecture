using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace MinimalAPI.Endpoints;

/// <summary>
/// Swagger
/// </summary>
public class SwaggerEndPoint : IEndPointDefinition
{
    /// <summary>  /// Add Swagger generation  /// </summary>  /// <param name="services"></param>  
    public void DefineServices(IServiceCollection services)
    {
        services.AddEndpointsApiExplorer(); services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minimal API", Version = "v1", Description = "API Core services and its endpoints" });
            c.EnableAnnotations();
            var securityScheme = new OpenApiSecurityScheme 
                        {   Name = "JWT Authorization",
                            Description = "Enter JWT Bearer token", 
                            In = ParameterLocation.Header, 
                            Type = SecuritySchemeType.Http, 
                            BearerFormat = "JWT", Scheme = "Bearer", 
                            Reference = new OpenApiReference 
                                        { 
                                            Id = JwtBearerDefaults.AuthenticationScheme, 
                                            Type = ReferenceType.SecurityScheme 
                                        } 
                        };
            c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme); 
            c.AddSecurityRequirement(new OpenApiSecurityRequirement { { securityScheme, Array.Empty<string>() } });
            c.CustomSchemaIds(x => x.FullName);
        });
    }
    /// <summary>  /// Use swagger endpoints  /// </summary>  /// <param name="app"></param>  
    public void DefineEndPoints(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {      // Enable middleware to serve generated Swagger as a JSON endpoint.     
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.     
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minimal API V1"));
        }
    }

}
