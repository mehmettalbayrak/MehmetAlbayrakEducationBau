using BooksApp.Business.Abstract;
using BooksApp.Business.Concrete;
using BooksApp.Data.Abstract;
using BooksApp.Data.Concrete.EfCore.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAuthorService, AuthorManager>();
builder.Services.AddScoped<IBookService, BookManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IPublisherService, PublisherManager>();

builder.Services.AddScoped<IAuthorRepository, EfCoreAuthorRepository>();
builder.Services.AddScoped<IBookRepository, EfCoreBookRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<IPublisherRepository, EfCorePublisherRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "booksauthor",
    pattern: "kitaplar/{authorurl?}",
    defaults: new { controller = "BooksShop", action = "BookList" }
    );

app.MapControllerRoute(
    name:"bookscategory",
    pattern: "kitaplar/{categoryurl?}",
    defaults: new { controller="BooksShop", action="BookList"}
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
