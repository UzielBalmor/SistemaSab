using Microsoft.EntityFrameworkCore;
using SERVIDOR.models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BlazorContext>(opciones =>
{
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
