namespace Car_Dealership.IoC;

public class SwaggerConfiguration
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddEndpointsApiExplorer(); 
        services.AddSwaggerGen();
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        app.UseSwagger(); 
        app.UseSwaggerUI();
    }
}