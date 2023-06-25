using AspNetCoreHero.ToastNotification;
using BooksApp.Business.Abstract;
using BooksApp.Business.Concrete;
using BooksApp.Data.Abstract;
using BooksApp.Data.Concrete.EfCore.Contexts;
using BooksApp.Data.Concrete.EfCore.Repositories;
using BooksApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BooksAppContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));


builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<BooksAppContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;

    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; //Eðer kullanýcý eriþebilmesi için login olmak zorunda olduðu bir istekte bulunursa, yönlendirelecek path.
    options.LogoutPath = "/account/logout"; //Logout olduðunda yönlendirilecek action.
    options.AccessDeniedPath = "/account/accessdenied"; //kullanýcý yetkisi olmayan bir endpointe istekte bulunursa yönlendirileceði path.
    options.ExpireTimeSpan = TimeSpan.FromMinutes(3); //Cookie'nin hayatta kalma süresi.
    options.SlidingExpiration = true; //her yeni istekte bulunulduðunda cookie'nin yaþam süresi sýfýrlansýn ve yeniden baþlasýn.
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true, //sadece http ile baðlantý kurulabilsin. günvenlik gerekçiþiyle yapýyoruz. hackerlar web iletiþim yollarýndan saldýrý yapamasýn diye.
        SameSite = SameSiteMode.Strict, //bizim için benzer sitelerin hepsini engellemeye çalýþýyor. 
        Name = "BooksApp.Security.Cookie"

    };
});

builder.Services.AddScoped<IAuthorService, AuthorManager>();
builder.Services.AddScoped<IBookService, BookManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IPublisherService, PublisherManager>();

builder.Services.AddScoped<IAuthorRepository, EfCoreAuthorRepository>();
builder.Services.AddScoped<IBookRepository, EfCoreBookRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<IPublisherRepository, EfCorePublisherRepository>();

builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 5;
    config.IsDismissable = true;
    config.Position = NotyfPosition.BottomRight;
});
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "bookdetails",
    pattern: "kitapdetay/{url}",
    defaults: new { controller = "BooksShop", action = "BookDetails" }
    );

app.MapControllerRoute(
    name: "bookspublisher",
    pattern: "kitaplar/{publisherurl?}",
    defaults: new { controller = "BooksShop", action = "BookList" }
    );

app.MapControllerRoute(
    name: "booksauthor",
    pattern: "kitaplar/{authorurl?}",
    defaults: new { controller = "BooksShop", action = "BookList" }
    );

app.MapControllerRoute(
    name: "bookscategory",
    pattern: "kitaplar/{categoryurl?}",
    defaults: new { controller = "BooksShop", action = "BookList" }
    );



app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "admin/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
