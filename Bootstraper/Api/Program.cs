var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// *-- Register services --*
builder.Services.AddBasketModule(builder.Configuration)
                .AddCatalogModule(builder.Configuration)
                .AddOrderingModule(builder.Configuration);

var app = builder.Build();

app.UseRouting();

// *--Configure the HTTP request pipeline--*
app.UseBasketModule();
app.UseCatalogModule();
app.UseOrderingModule();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
