using DemoSession5_Session.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddScoped<ProductSevices, ProductSevicesImpl>();


var app = builder.Build();

app.UseSession();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
);


app.Run();
