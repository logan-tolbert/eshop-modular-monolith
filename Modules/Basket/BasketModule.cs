public static class BasketModule
{
    public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration config)
    {
        // services.AddTransient<IBasketService, BasketService>();
        // services.AddScoped<IBasketRepo, BasketRepo>();
        return services;
    }

     public static IApplicationBuilder UseBasketModule(this IApplicationBuilder builder)
    {
        
        return builder;
    }
}