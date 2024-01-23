using DemoSession4_ASPNET_CORE_MVC.Models;
using DemoSession4_ASPNET_CORE_MVC.Services;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var config1 = builder.Configuration["Config1"];
Debug.WriteLine("config 1 - program: " + config1);

var config2 = builder.Configuration["Config2:Config21"];
Debug.WriteLine("config 2 - program: " + config2);

var connectionString = builder.Configuration["ConnectionStrings"];
builder.Services.AddDbContext<DatabaseContext>(option => option.UseLazyLoadingProxies().UseSqlServer(connectionString));

builder.Services.AddScoped<CategoryService, CategoryServiceImpl>();
builder.Services.AddScoped<ProductService, ProductServiceImpl>();
builder.Services.AddScoped<RoleService, RoleServiceImpl>();
builder.Services.AddScoped<AccountService, AccountServiceImpl>();
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
);


app.Run();
