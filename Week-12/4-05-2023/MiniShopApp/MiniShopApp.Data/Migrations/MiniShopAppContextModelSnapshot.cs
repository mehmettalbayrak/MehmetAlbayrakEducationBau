﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShopApp.Data.Concrete.EFCore.Contexts;

#nullable disable

namespace MiniShopApp.Data.Migrations
{
    [DbContext(typeof(MiniShopAppContext))]
    partial class MiniShopAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("MiniShopApp.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3850),
                            Description = "Telefonlar",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3862),
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3866),
                            Description = "Bilgisayarlar",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3867),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3870),
                            Description = "Elektronik ürünler burada",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3870),
                            Name = "Elektronik",
                            Url = "elektronik"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3873),
                            Description = "Beyaz Eşyalar Burada",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3873),
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        });
                });

            modelBuilder.Entity("MiniShopApp.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6324),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6330),
                            Name = "iPhone 13",
                            Price = 29000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-13-256GB"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6335),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6336),
                            Name = "Samsung S64",
                            Price = 25000m,
                            Properties = "Harika bir telefon diyorlar",
                            Url = "samsung-s-64"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6339),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6339),
                            Name = "iPhone 14 Pro Max",
                            Price = 49000m,
                            Properties = "Harika bir telefon ama çok pahalı",
                            Url = "iphone-14-pro-max-516gb"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6341),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6342),
                            Name = "Huawei Mate 20D",
                            Price = 21000m,
                            Properties = "Fiyat performans ürünü",
                            Url = "huawei-mate-20d"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6344),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6345),
                            Name = "Vestel NFR 7500",
                            Price = 23000m,
                            Properties = "Nofrost",
                            Url = "vestel-nfr-7500"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6347),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6348),
                            Name = "Arçelik AR8000 Toz Torbasız",
                            Price = 7000m,
                            Properties = "Toz torbasına son",
                            Url = "arcelik-ar-8000-toz-torbasız"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6350),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6350),
                            Name = "Arzum Okka Türk Kahvesi Makinesi",
                            Price = 1300m,
                            Properties = "Türk Kahvesini Dünyaya Tanıtan Model",
                            Url = "arzum-turk-kahvesi"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6352),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6353),
                            Name = "MacBook Air M2 16GB",
                            Price = 24500m,
                            Properties = "Daha güçlü",
                            Url = "macbook-air-m2-16gb"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6355),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6356),
                            Name = "Asus Zenbook 12XR",
                            Price = 22000m,
                            Properties = "Fan mı? O da ne?",
                            Url = "asus-zenbook-12xr"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6358),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6358),
                            Name = "Dell TRE Amd Ryzen",
                            Price = 26500m,
                            Properties = "32GB RAM",
                            Url = "dell-tre-amd-ryzen"
                        });
                });

            modelBuilder.Entity("MiniShopApp.Entity.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4
                        });
                });

            modelBuilder.Entity("MiniShopApp.Entity.Concrete.ProductCategory", b =>
                {
                    b.HasOne("MiniShopApp.Entity.Concrete.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShopApp.Entity.Concrete.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Concrete.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Concrete.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
