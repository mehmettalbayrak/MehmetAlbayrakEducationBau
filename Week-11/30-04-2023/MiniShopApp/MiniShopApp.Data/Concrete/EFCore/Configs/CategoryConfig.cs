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
        //modelBuilder komutunu k�saltarak kullanmak ve daha d�zenli yap�m�z� olu�turmak i�in Configs klas�r� i�erisinde Database'imizi yap�land�r�yoruz.
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id); //Bu primary key olmas�n� sa�lad�
            builder.Property(c => c.Id); //Identity olmas�n� sa�lad� (birer birer artma)
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100); //Zorunlu olmas�n� (not null) ve max 100 karakter olmas�n� sa�lad�.
            builder.Property(c => c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Url).IsRequired().HasMaxLength(500);
            builder.ToTable("Categories"); //Tablo ismini parantez i�inde ne olmas�n� istiyorsak de�i�tirmemizi sa�lar.

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
                    Description = "Elektronik �r�nler burada",
                    Url = "elektronik"
                },
                new Category
                {
                    Id = 4,
                    Name = "Beyaz E�ya",
                    Description = "Beyaz E�yalar Burada",
                    Url = "beyaz-esya"
                }
                );
        }
    }
}
