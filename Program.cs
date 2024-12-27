using Car_Dealership.IoC;

var builder = WebApplication.CreateBuilder(args);

SerilogConfiguration.ConfigureService(builder);
SwaggerConfiguration.ConfigureServices(builder.Services);

var app = builder.Build();

SerilogConfiguration.ConfigureApplication(app);
SwaggerConfiguration.ConfigureApplication(app);

app.UseHttpsRedirection();
app.Run();