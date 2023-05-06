using MiniShopApp.Business.Abstract;
using MiniShopApp.Business.Concrete;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EFCore.Repisotories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Uygulaman�n ba�lang�c� s�ras�nda, hen�z derleme ger�ekle�memi�ken. CategoryManager tipinde bir nesne yarat�l�r ve bu nesne IOC(havuz) i�ine koyulur. Sonra uygulaman�n i�inde herhangi bir yerde ICategoryService tipinde bir nesne istendi�inde, ona az �nce yarat�ld���n� s�yledi�imiz CategoryManager tipinde bir nesne havuzdan verilecek.
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ICategoryRepository, EFCoreCategoryRepository>();
builder.Services.AddScoped<IProductRepository, EFCoreProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapControllerRoute(
    name: "productbycategory",
    pattern: "products/{categoryUrl}",
    defaults: new { controller = "Product", action = "Index" }
);

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "productdetails",
    pattern: "details/{url}",
    defaults: new { controller = "Product", action = "Details" }
);

app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
