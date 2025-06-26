
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// *-- Register services --*
builder.Services.AddBasketModule(builder.Configuration)
                .AddCatalogModule(builder.Configuration)
                .AddOrderingModule(builder.Configuration);

var app = builder.Build();

// *--Configure the HTTP request pipeline--*
app.UseBasketModule()
   .UseCatalogModule()
   .UseOrderingModule();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
})
app.Run();
