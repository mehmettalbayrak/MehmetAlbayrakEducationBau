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
    options.LoginPath = "/account/login"; //E�er kullan�c� eri�ebilmesi i�in login olmak zorunda oldu�u bir istekte bulunursa, y�nlendirelecek path.
    options.LogoutPath = "/account/logout"; //Logout oldu�unda y�nlendirilecek action.
    options.AccessDeniedPath = "/account/accessdenied"; //kullan�c� yetkisi olmayan bir endpointe istekte bulunursa y�nlendirilece�i path.
    options.ExpireTimeSpan = TimeSpan.FromMinutes(3); //Cookie'nin hayatta kalma s�resi.
    options.SlidingExpiration = true; //her yeni istekte bulunuldu�unda cookie'nin ya�am s�resi s�f�rlans�n ve yeniden ba�las�n.
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true, //sadece http ile ba�lant� kurulabilsin. g�nvenlik gerek�i�iyle yap�yoruz. hackerlar web ileti�im yollar�ndan sald�r� yapamas�n diye.
        SameSite = SameSiteMode.Strict, //bizim i�in benzer sitelerin hepsini engellemeye �al���yor. 
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
