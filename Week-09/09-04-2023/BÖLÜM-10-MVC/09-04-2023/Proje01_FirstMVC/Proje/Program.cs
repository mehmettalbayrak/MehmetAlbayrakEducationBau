var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Bizim uygulamamýz bir MVC uygulamasý.
//Model-View-Controller
//Uygulamaya gelen istekleri karþýlamak üzre Controller'lar, istemciye gereken html sayfasý sonucunu döndürmek üzere View'ler barýndýran uygulama mimarisidir. Model ise tüm bu süreçlerdeki veri ile ilgili yapýlandýrmalarý barýndýran kýsýmdýr.
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
