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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Properties).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Url).IsRequired();
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.ToTable("Products");

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "iPhone 13",
                    Price = 29000,
                    Properties = "Harika bir telefon",
                    Url = "iphone-13-256GB",
                    ImageUrl = "1.png",
                    IsHome = true
                },

                new Product
                {
                    Id = 2,
                    Name = "Samsung S64",
                    Price = 25000,
                    Properties = "Harika bir telefon diyorlar",
                    Url = "samsung-s-64",
                    ImageUrl = "2.png",
                    IsHome = false
                },

                new Product
                {
                    Id = 3,
                    Name = "iPhone 14 Pro Max",
                    Price = 49000,
                    Properties = "Harika bir telefon ama çok pahalý",
                    Url = "iphone-14-pro-max-516gb",
                    ImageUrl = "3.png",
                    IsHome = true
                },

                new Product
                {
                    Id = 4,
                    Name = "Huawei Mate 20D",
                    Price = 21000,
                    Properties = "Fiyat performans ürünü",
                    Url = "huawei-mate-20d",
                    ImageUrl = "4.png",
                    IsHome = false
                },

                new Product
                {
                    Id = 5,
                    Name = "Vestel NFR 7500",
                    Price = 23000,
                    Properties = "Nofrost",
                    Url = "vestel-nfr-7500",
                    ImageUrl = "5.png",
                    IsHome = true
                },

                new Product
                {
                    Id = 6,
                    Name = "Arçelik AR8000 Toz Torbasýz",
                    Price = 7000,
                    Properties = "Toz torbasýna son",
                    Url = "arcelik-ar-8000-toz-torbasýz",
                    ImageUrl = "6.png",
                    IsHome = false
                },

                new Product
                {
                    Id = 7,
                    Name = "Arzum Okka Türk Kahvesi Makinesi",
                    Price = 1300,
                    Properties = "Türk Kahvesini Dünyaya Tanýtan Model",
                    Url = "arzum-turk-kahvesi",
                    ImageUrl = "7.png",
                    IsHome = false
                },

                new Product
                {
                    Id = 8,
                    Name = "MacBook Air M2 16GB",
                    Price = 24500,
                    Properties = "Daha güçlü",
                    Url = "macbook-air-m2-16gb",
                    ImageUrl = "8.png",
                    IsHome = true
                },

                new Product
                {
                    Id = 9,
                    Name = "Asus Zenbook 12XR",
                    Price = 22000,
                    Properties = "Fan mý? O da ne?",
                    Url = "asus-zenbook-12xr",
                    ImageUrl = "9.png",
                    IsHome = false
                },

                new Product
                {
                    Id = 10,
                    Name = "Dell TRE Amd Ryzen",
                    Price = 26500,
                    Properties = "32GB RAM",
                    Url = "dell-tre-amd-ryzen",
                    ImageUrl = "10.png",
                    IsHome = false
                }
                );
        }
    }
}
