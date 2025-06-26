public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration config)
    {
        // services.AddTransient<ICatalogService, CatalogService>();
        // services.AddScoped<ICatalogRepository, CatalogRepository>();
        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder builder)
    {
        
        return builder;
    }
}