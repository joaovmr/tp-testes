namespace RealEstate.WebApi;

public static class Startup
{
    public static WebApplication CreateApp(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.ConfigureServices();
        
        var app = builder.Build();
        app.Configure();

        return app;
    }
}