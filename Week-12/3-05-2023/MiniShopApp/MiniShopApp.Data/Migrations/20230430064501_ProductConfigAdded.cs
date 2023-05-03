using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShopApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductConfigAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Properties",
                table: "Products",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 4, 30, 9, 45, 1, 539, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1898), "1.png", true, false, true, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1902), "iPhone 13", 29000m, "Harika bir telefon", "iphone-13-256GB" },
                    { 2, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1907), "2.png", true, false, false, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1908), "Samsung S64", 25000m, "Harika bir telefon diyorlar", "samsung-s-64" },
                    { 3, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1911), "3.png", true, false, true, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1911), "iPhone 14 Pro Max", 49000m, "Harika bir telefon ama çok pahalı", "iphone-14-pro-max-516gb" },
                    { 4, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1914), "4.png", true, false, false, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1914), "Huawei Mate 20D", 21000m, "Fiyat performans ürünü", "huawei-mate-20d" },
                    { 5, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1916), "5.png", true, false, true, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1917), "Vestel NFR 7500", 23000m, "Nofrost", "vestel-nfr-7500" },
                    { 6, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1919), "6.png", true, false, false, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1920), "Arçelik AR8000 Toz Torbasız", 7000m, "Toz torbasına son", "arcelik-ar-8000-toz-torbasız" },
                    { 7, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1922), "7.png", true, false, false, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1923), "Arzum Okka Türk Kahvesi Makinesi", 1300m, "Türk Kahvesini Dünyaya Tanıtan Model", "arzum-turk-kahvesi" },
                    { 8, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1925), "8.png", true, false, true, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1926), "MacBook Air M2 16GB", 24500m, "Daha güçlü", "macbook-air-m2-16gb" },
                    { 9, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1928), "9.png", true, false, false, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1928), "Asus Zenbook 12XR", 22000m, "Fan mı? O da ne?", "asus-zenbook-12xr" },
                    { 10, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1930), "10.png", true, false, false, new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1931), "Dell TRE Amd Ryzen", 26500m, "32GB RAM", "dell-tre-amd-ryzen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Properties",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(586), new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(588), new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(590), new DateTime(2023, 4, 29, 14, 51, 23, 545, DateTimeKind.Local).AddTicks(591) });
        }
    }
}
