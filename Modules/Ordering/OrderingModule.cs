namespace Ordering;

public static class OrderingModule
{
    public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration config)
    {
        // services.AddTransient<IOrderingService, OrderingService>();
        // services.AddScoped<IOrderingRepo, OrderingRepo>();
        return services;
    }

    public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder builder)
    {

        return builder;
    }
}