using Demo_Session3_MVC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<DemoService, DemoServiceImpl>();
builder.Services.AddScoped<CalculateService, CalculateServiceImpl>();
builder.Services.AddScoped<RectangleService, RectangleServiceImpl>();
builder.Services.AddScoped<ProductService, ProductServiceImpl>();
builder.Services.AddScoped<AccountService, AccountServiceImpl>();
builder.Services.AddScoped<LanguageService, LanguageServiceImpl>();
builder.Services.AddScoped<CertService, CertServiceImpl>();
builder.Services.AddScoped<RoleService, RoleServiceImpl>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
);

app.Run();
