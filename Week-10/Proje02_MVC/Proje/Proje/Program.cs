var builder = WebApplication.CreateBuilder(args);//Web Application builder olu�turduk.

builder.Services.AddControllersWithViews(); //MVC uygulamas� olmas�n� sa�lad�k.





var app = builder.Build(); //Web application olu�turduk.

app.UseHttpsRedirection(); //http g�venlik protokol�.
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
