var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "biblioteca",
    pattern: "biblioteca/libros/{action=Index}/{id?}",
    defaults: new { controller = "Libros", action = "Index" })
    .WithStaticAssets();

app.MapControllerRoute(
    name: "anterior",
    pattern: "{controller=Libros}/{action=Index}/{id?}");


app.Run();
