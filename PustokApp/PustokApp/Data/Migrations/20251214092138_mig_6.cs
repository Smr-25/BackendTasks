using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pustok.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "products/product-details-2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "products/product-details-3.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "products/product-details-4.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "products/product-details-5.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "products/product-details-1.jpg");

            migrationBuilder.InsertData(
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 4, 1 },
                    { 4, 8 },
                    { 5, 8 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 6 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 2 },
                    { 8, 8 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 10, 2 },
                    { 10, 4 },
                    { 11, 2 },
                    { 11, 4 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 5 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 5 },
                    { 14, 1 },
                    { 14, 3 },
                    { 14, 5 },
                    { 15, 1 },
                    { 15, 3 },
                    { 15, 5 },
                    { 16, 1 },
                    { 16, 5 },
                    { 16, 7 },
                    { 17, 1 },
                    { 17, 2 },
                    { 17, 5 },
                    { 18, 1 },
                    { 18, 2 },
                    { 18, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-2.jpg", "products/product-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-4.jpg", "products/product-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-6.jpg", "products/product-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-8.jpg", "products/product-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-10.jpg", "products/product-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-12.jpg", "products/product-11.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-1.jpg", "products/product-13.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-3.jpg", "products/product-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-5.jpg", "products/product-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-7.jpg", "products/product-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-9.jpg", "products/product-8.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-11.jpg", "products/product-10.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-13.jpg", "products/product-12.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-2.jpg", "products/product-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-4.jpg", "products/product-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-6.jpg", "products/product-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-8.jpg", "products/product-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "products/product-10.jpg", "products/product-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "bg-images/home-2-slider-1.jpg");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "bg-images/home-2-slider-2.jpg");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "bg-images/home-3-slider-1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "great-gatsby-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "great-gatsby-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "tender-night-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "tender-night-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "paradise-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "paradise-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "mockingbird-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "mockingbird-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "watchman-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "watchman-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "1984-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "1984-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "animal-farm-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "animal-farm-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "catalonia-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "catalonia-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "pride-prejudice-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "pride-prejudice-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "sense-sensibility-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "sense-sensibility-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "emma-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "emma-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "huckleberry-finn-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "huckleberry-finn-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "tom-sawyer-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "tom-sawyer-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "hp-stone-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "hp-stone-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "hp-chamber-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "hp-chamber-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "hp-azkaban-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "hp-azkaban-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "old-man-sea-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "old-man-sea-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "farewell-arms-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "farewell-arms-detail2.jpg");

            migrationBuilder.InsertData(
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { 2, 8 },
                    { 3, 3 },
                    { 3, 6 },
                    { 4, 4 },
                    { 5, 2 },
                    { 5, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "great-gatsby-hover.jpg", "great-gatsby.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "tender-night-hover.jpg", "tender-night.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "paradise-hover.jpg", "paradise.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "mockingbird-hover.jpg", "mockingbird.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "watchman-hover.jpg", "watchman.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "1984-hover.jpg", "1984.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "animal-farm-hover.jpg", "animal-farm.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "catalonia-hover.jpg", "catalonia.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "pride-prejudice-hover.jpg", "pride-prejudice.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "sense-sensibility-hover.jpg", "sense-sensibility.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "emma-hover.jpg", "emma.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "huckleberry-finn-hover.jpg", "huckleberry-finn.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "tom-sawyer-hover.jpg", "tom-sawyer.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "hp-stone-hover.jpg", "hp-stone.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "hp-chamber-hover.jpg", "hp-chamber.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "hp-azkaban-hover.jpg", "hp-azkaban.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "old-man-sea-hover.jpg", "old-man-sea.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "HoverImageUrl", "MainImageUrl" },
                values: new object[] { "farewell-arms-hover.jpg", "farewell-arms.jpg" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "slider1.jpg");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "slider2.jpg");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "slider3.jpg");
        }
    }
}
