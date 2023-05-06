using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShopApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductCategoryConfigAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3850), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 5 },
                    { 3, 6 },
                    { 4, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 2, 8 },
                    { 4, 8 },
                    { 2, 9 },
                    { 4, 9 },
                    { 2, 10 },
                    { 4, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6358), new DateTime(2023, 4, 30, 10, 6, 31, 155, DateTimeKind.Local).AddTicks(6358) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 10 });

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1898), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1916), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1919), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1922), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1925), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1928), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1930), new DateTime(2023, 4, 30, 9, 45, 1, 540, DateTimeKind.Local).AddTicks(1931) });
        }
    }
}
