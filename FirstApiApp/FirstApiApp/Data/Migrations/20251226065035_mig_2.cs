using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstApiApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UptadeDate" },
                values: new object[,]
                {
                    { 1, "This is a sample category 1", "Sample Category 1", null },
                    { 2, "This is a sample category 2", "Sample Category 2", null },
                    { 3, "This is a sample category 3", "Sample Category 3", null },
                    { 4, "This is a sample category 4", "Sample Category 4", null },
                    { 5, "This is a sample category 5", "Sample Category 5", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "UptadeDate" },
                values: new object[,]
                {
                    { 1, 1, "This is a sample product 1", "Sample Product 1", 9.99m, null },
                    { 2, 1, "This is a sample product 2", "Sample Product 2", 19.99m, null },
                    { 3, 2, "This is a sample product 3", "Sample Product 3", 29.99m, null },
                    { 4, 2, "This is a sample product 4", "Sample Product 4", 39.99m, null },
                    { 5, 3, "This is a sample product 5", "Sample Product 5", 49.99m, null },
                    { 6, 3, "This is a sample product 6", "Sample Product 6", 59.99m, null },
                    { 7, 4, "This is a sample product 7", "Sample Product 7", 69.99m, null },
                    { 8, 4, "This is a sample product 8", "Sample Product 8", 79.99m, null },
                    { 9, 5, "This is a sample product 9", "Sample Product 9", 89.99m, null },
                    { 10, 5, "This is a sample product 10", "Sample Product 10", 99.99m, null }
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
