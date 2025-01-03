using MiniShopApp.Business.Abstract;
using MiniShopApp.Business.Concrete;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EFCore.Repisotories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Uygulamanın başlangıcı sırasında, henüz derleme gerçekleşmemişken. CategoryManager tipinde bir nesne yaratılır ve bu nesne IOC(havuz) içine koyulur. Sonra uygulamanın içinde herhangi bir yerde ICategoryService tipinde bir nesne istendiğinde, ona az önce yaratıldığını söylediğimiz CategoryManager tipinde bir nesne havuzdan verilecek.
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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
