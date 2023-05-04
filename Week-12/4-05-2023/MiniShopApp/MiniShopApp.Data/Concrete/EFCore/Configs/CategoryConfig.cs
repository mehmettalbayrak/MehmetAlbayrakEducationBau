using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        //modelBuilder komutunu kýsaltarak kullanmak ve daha düzenli yapýmýzý oluþturmak için Configs klasörü içerisinde Database'imizi yapýlandýrýyoruz.
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id); //Bu primary key olmasýný saðladý
            builder.Property(c => c.Id); //Identity olmasýný saðladý (birer birer artma)
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100); //Zorunlu olmasýný (not null) ve max 100 karakter olmasýný saðladý.
            builder.Property(c => c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Url).IsRequired().HasMaxLength(500);
            builder.ToTable("Categories"); //Tablo ismini parantez içinde ne olmasýný istiyorsak deðiþtirmemizi saðlar.

            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Telefon",
                    Description = "Telefonlar",
                    Url = "telefon"
                },
                new Category
                {
                    Id = 2,
                    Name = "Bilgisayar",
                    Description = "Bilgisayarlar",
                    Url = "bilgisayar"
                },
                new Category
                {
                    Id = 3,
                    Name = "Elektronik",
                    Description = "Elektronik ürünler burada",
                    Url = "elektronik"
                },
                new Category
                {
                    Id = 4,
                    Name = "Beyaz Eþya",
                    Description = "Beyaz Eþyalar Burada",
                    Url = "beyaz-esya"
                }
                );
        }
    }
}
