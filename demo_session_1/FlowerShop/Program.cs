var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// mọi thứ đều đc tự động hết, khi khai báo controller và view xong, ta chỉ cần gọi TÊN controller, và method của nó, và param nếu có, toàn bộ quá trình này đều dùng trong route
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Demo2}/{action=index}/{id?}/{username?}"
);




app.Run();
