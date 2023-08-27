var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // добавляем сервисы MVC
var app = builder.Build();


// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "claims",
    pattern: "{controller=Claims}/{id?}");
app.MapControllerRoute(
    name: "claimsCreation",
    pattern: "{controller=ClaimsCreation}/{id?}");
app.MapControllerRoute(
    name: "claimsEdit",
    pattern: "{controller=ClaimsEdit}/{id?}");
app.UseStaticFiles();
app.Run();