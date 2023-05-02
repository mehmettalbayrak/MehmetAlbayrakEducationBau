using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Concrete.EFCore.Configs;
using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore.Contexts
{
    public class MiniShopAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MiniShopApp.db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ConfigYapilanmasiniKullanmadanOncekiHali
            //modelBuilder.Entity<ProductCategory>().HasNoKey(); //Bu primary key sahip olmayan bir tablo yaratýlmasýný saðlayacak.

            ////Product Ayarlarý
            //modelBuilder.Entity<Product>().HasKey(p => p.Id); //Bu satýr her bir product satýrýndaki (p=>) Id (p.Id) primary key olsun.
            //modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd(); //1'den baþlayýp birer birer artsýn demek.

            ////modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(100); //istersek aþaðýdakini böyle de yazabiliriz.

            //modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired(); //Name sütununu not null yaptýk(doldurulmasý zorunlu.). Eðer böyle olmasýn istiyorsak isRequired(false) yazabiliriz.
            //modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(100);
            #endregion
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            //modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryId }); //Burada {}(süslü parantez) içinde bir obje oluþturduk. Ve bu komut sayesinde productcategory entitysi kullanarak oluþturulacak tabloda (productcategories) ProductId-CategoryId ikilisi Primary key olarak tanýmlanmýþ olacak. Böylece bu ikilinin ayný deðerleri taþýyan birden fazla satýr almasý mümkün deðil.
            base.OnModelCreating(modelBuilder);
        }
    }
}
