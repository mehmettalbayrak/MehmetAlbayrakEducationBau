﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShopApp.Data.Concrete.EFCore.Contexts;

#nullable disable

namespace MiniShopApp.Data.Migrations
{
    [DbContext(typeof(MiniShopAppContext))]
    [Migration("20230430064501_ProductConfigAdded")]
    partial class ProductConfigAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9979),
                            Description = "Telefonlar",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9992),
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9995),
                            Description = "Bilgisayarlar",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9995),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9998),
                            Description = "Elektronik ürünler burada",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9998),
                            Name = "Elektronik",
                            Url = "elektronik"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local),
                            Description = "Beyaz Eşyalar Burada",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local),
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
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1898),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1902),
                            Name = "iPhone 13",
                            Price = 29000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-13-256GB"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1907),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1908),
                            Name = "Samsung S64",
                            Price = 25000m,
                            Properties = "Harika bir telefon diyorlar",
                            Url = "samsung-s-64"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1911),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1911),
                            Name = "iPhone 14 Pro Max",
                            Price = 49000m,
                            Properties = "Harika bir telefon ama çok pahalı",
                            Url = "iphone-14-pro-max-516gb"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1914),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1914),
                            Name = "Huawei Mate 20D",
                            Price = 21000m,
                            Properties = "Fiyat performans ürünü",
                            Url = "huawei-mate-20d"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1916),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1917),
                            Name = "Vestel NFR 7500",
                            Price = 23000m,
                            Properties = "Nofrost",
                            Url = "vestel-nfr-7500"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1919),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1920),
                            Name = "Arçelik AR8000 Toz Torbasız",
                            Price = 7000m,
                            Properties = "Toz torbasına son",
                            Url = "arcelik-ar-8000-toz-torbasız"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1922),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1923),
                            Name = "Arzum Okka Türk Kahvesi Makinesi",
                            Price = 1300m,
                            Properties = "Türk Kahvesini Dünyaya Tanıtan Model",
                            Url = "arzum-turk-kahvesi"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1925),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1926),
                            Name = "MacBook Air M2 16GB",
                            Price = 24500m,
                            Properties = "Daha güçlü",
                            Url = "macbook-air-m2-16gb"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1928),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1928),
                            Name = "Asus Zenbook 12XR",
                            Price = 22000m,
                            Properties = "Fan mı? O da ne?",
                            Url = "asus-zenbook-12xr"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1930),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1931),
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

                    b.ToTable("ProductCategories");
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