var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Bizim uygulamam�z bir MVC uygulamas�.
//Model-View-Controller
//Uygulamaya gelen istekleri kar��lamak �zre Controller'lar, istemciye gereken html sayfas� sonucunu d�nd�rmek �zere View'ler bar�nd�ran uygulama mimarisidir. Model ise t�m bu s�re�lerdeki veri ile ilgili yap�land�rmalar� bar�nd�ran k�s�md�r.
builder.Services.AddControllersWithViews();

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
