var builder = WebApplication.CreateBuilder(args);//Web Application builder oluþturduk.

builder.Services.AddControllersWithViews(); //MVC uygulamasý olmasýný saðladýk.





var app = builder.Build(); //Web application oluþturduk.

app.UseHttpsRedirection(); //http güvenlik protokolü.
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
/*app.MapDefaultControllerRoute();*/
//https://localhost:5275/Home/Index
//https://localhost:5275/Home
//https://localhost:5275/Products/GetByProduct/25
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );







app.Run();
