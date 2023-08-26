var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // ��������� ������� MVC
var app = builder.Build();


// ������������� ������������� ��������� � �������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "claims",
    pattern: "{controller=Claims}/{id?}");
app.MapControllerRoute(
    name: "claimsCreation",
    pattern: "{controller=ClaimsCreation}/{id?}");
app.UseStaticFiles();
app.Run();