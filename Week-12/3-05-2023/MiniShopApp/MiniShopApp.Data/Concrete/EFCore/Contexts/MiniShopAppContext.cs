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
            //modelBuilder.Entity<ProductCategory>().HasNoKey(); //Bu primary key sahip olmayan bir tablo yarat�lmas�n� sa�layacak.

            ////Product Ayarlar�
            //modelBuilder.Entity<Product>().HasKey(p => p.Id); //Bu sat�r her bir product sat�r�ndaki (p=>) Id (p.Id) primary key olsun.
            //modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd(); //1'den ba�lay�p birer birer arts�n demek.

            ////modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(100); //istersek a�a��dakini b�yle de yazabiliriz.

            //modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired(); //Name s�tununu not null yapt�k(doldurulmas� zorunlu.). E�er b�yle olmas�n istiyorsak isRequired(false) yazabiliriz.
            //modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(100);
            #endregion
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            //modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryId }); //Burada {}(s�sl� parantez) i�inde bir obje olu�turduk. Ve bu komut sayesinde productcategory entitysi kullanarak olu�turulacak tabloda (productcategories) ProductId-CategoryId ikilisi Primary key olarak tan�mlanm�� olacak. B�ylece bu ikilinin ayn� de�erleri ta��yan birden fazla sat�r almas� m�mk�n de�il.
            base.OnModelCreating(modelBuilder);
        }
    }
}
