using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pustok.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "J.K. Rowling" },
                    { 7, "Ernest Hemingway" }
                });

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
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Description", "DiscountPercent", "HoverImageUrl", "IsFeatured", "MainImageUrl", "Name", "Price" },
                values: new object[] { 1, "A story of a psychiatrist's descent into alcoholism", 5, "tender-night-hover.jpg", false, "tender-night.jpg", "Tender Is the Night", 16.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Description", "HoverImageUrl", "IsNew", "MainImageUrl", "Name" },
                values: new object[] { 1, "The debut novel about post-World War I youth", "paradise-hover.jpg", false, "paradise.jpg", "This Side of Paradise" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Description", "DiscountPercent", "HoverImageUrl", "MainImageUrl", "Name", "Price" },
                values: new object[] { 2, "A gripping tale of racial injustice", 15, "mockingbird-hover.jpg", "mockingbird.jpg", "To Kill a Mockingbird", 18.50m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Description", "DiscountPercent", "HoverImageUrl", "MainImageUrl", "Name", "Price" },
                values: new object[] { 2, "A sequel to To Kill a Mockingbird", 10, "watchman-hover.jpg", "watchman.jpg", "Go Set a Watchman", 17.99m });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Code", "Description", "DiscountPercent", "HoverImageUrl", "InStock", "IsFeatured", "IsNew", "MainImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 6, 3, "BK006", "A dystopian social science fiction novel", 0, "1984-hover.jpg", true, true, true, "1984.jpg", "1984", 14.99m },
                    { 7, 3, "BK007", "An allegorical novella about Soviet totalitarianism", 5, "animal-farm-hover.jpg", true, true, false, "animal-farm.jpg", "Animal Farm", 13.99m },
                    { 8, 3, "BK008", "Orwell's account of the Spanish Civil War", 0, "catalonia-hover.jpg", true, false, false, "catalonia.jpg", "Homage to Catalonia", 15.50m },
                    { 9, 4, "BK009", "A romantic novel of manners", 20, "pride-prejudice-hover.jpg", true, true, false, "pride-prejudice.jpg", "Pride and Prejudice", 12.99m },
                    { 10, 4, "BK010", "A story of two sisters and their romantic adventures", 15, "sense-sensibility-hover.jpg", true, false, false, "sense-sensibility.jpg", "Sense and Sensibility", 13.99m },
                    { 11, 4, "BK011", "A comedy of manners about youthful hubris", 10, "emma-hover.jpg", true, false, false, "emma.jpg", "Emma", 14.50m },
                    { 12, 5, "BK012", "A classic American adventure novel", 5, "huckleberry-finn-hover.jpg", true, true, true, "huckleberry-finn.jpg", "Adventures of Huckleberry Finn", 13.50m },
                    { 13, 5, "BK013", "A boy's adventures in a Mississippi River town", 5, "tom-sawyer-hover.jpg", true, false, false, "tom-sawyer.jpg", "The Adventures of Tom Sawyer", 12.99m }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "address", "123 Book Street, Reading City, RC 12345" },
                    { "instagram", "https://instagram.com/pustok" },
                    { "logourl", "logo.png" },
                    { "phone", "+1 (555) 123-4567" }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "ImageUrl" },
                values: new object[,]
                {
                    { 11, 6, "1984-detail1.jpg" },
                    { 12, 6, "1984-detail2.jpg" },
                    { 13, 7, "animal-farm-detail1.jpg" },
                    { 14, 7, "animal-farm-detail2.jpg" },
                    { 15, 8, "catalonia-detail1.jpg" },
                    { 16, 8, "catalonia-detail2.jpg" },
                    { 17, 9, "pride-prejudice-detail1.jpg" },
                    { 18, 9, "pride-prejudice-detail2.jpg" },
                    { 19, 10, "sense-sensibility-detail1.jpg" },
                    { 20, 10, "sense-sensibility-detail2.jpg" },
                    { 21, 11, "emma-detail1.jpg" },
                    { 22, 11, "emma-detail2.jpg" },
                    { 23, 12, "huckleberry-finn-detail1.jpg" },
                    { 24, 12, "huckleberry-finn-detail2.jpg" },
                    { 25, 13, "tom-sawyer-detail1.jpg" },
                    { 26, 13, "tom-sawyer-detail2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Code", "Description", "DiscountPercent", "HoverImageUrl", "InStock", "IsFeatured", "IsNew", "MainImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 14, 6, "BK014", "A young wizard's first year at Hogwarts", 25, "hp-stone-hover.jpg", true, true, true, "hp-stone.jpg", "Harry Potter and the Philosopher's Stone", 19.99m },
                    { 15, 6, "BK015", "Harry's second year at Hogwarts", 20, "hp-chamber-hover.jpg", true, true, true, "hp-chamber.jpg", "Harry Potter and the Chamber of Secrets", 20.99m },
                    { 16, 6, "BK016", "Harry's third year brings new dangers", 20, "hp-azkaban-hover.jpg", true, false, true, "hp-azkaban.jpg", "Harry Potter and the Prisoner of Azkaban", 21.99m },
                    { 17, 7, "BK017", "An aging fisherman's epic struggle with a giant marlin", 10, "old-man-sea-hover.jpg", true, true, false, "old-man-sea.jpg", "The Old Man and the Sea", 16.50m },
                    { 18, 7, "BK018", "A love story set during World War I", 5, "farewell-arms-hover.jpg", true, false, false, "farewell-arms.jpg", "A Farewell to Arms", 17.99m }
                });

            migrationBuilder.InsertData(
                table: "BookImages",
                columns: new[] { "Id", "BookId", "ImageUrl" },
                values: new object[,]
                {
                    { 27, 14, "hp-stone-detail1.jpg" },
                    { 28, 14, "hp-stone-detail2.jpg" },
                    { 29, 15, "hp-chamber-detail1.jpg" },
                    { 30, 15, "hp-chamber-detail2.jpg" },
                    { 31, 16, "hp-azkaban-detail1.jpg" },
                    { 32, 16, "hp-azkaban-detail2.jpg" },
                    { 33, 17, "old-man-sea-detail1.jpg" },
                    { 34, 17, "old-man-sea-detail2.jpg" },
                    { 35, 18, "farewell-arms-detail1.jpg" },
                    { 36, 18, "farewell-arms-detail2.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Key",
                keyValue: "address");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Key",
                keyValue: "instagram");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Key",
                keyValue: "logourl");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Key",
                keyValue: "phone");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "mockingbird-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "mockingbird-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "1984-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "1984-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "pride-prejudice-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "pride-prejudice-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "huckleberry-finn-detail1.jpg");

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "huckleberry-finn-detail2.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Description", "DiscountPercent", "HoverImageUrl", "IsFeatured", "MainImageUrl", "Name", "Price" },
                values: new object[] { 2, "A gripping tale of racial injustice", 15, "mockingbird-hover.jpg", true, "mockingbird.jpg", "To Kill a Mockingbird", 18.50m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Description", "HoverImageUrl", "IsNew", "MainImageUrl", "Name" },
                values: new object[] { 3, "A dystopian social science fiction novel", "1984-hover.jpg", true, "1984.jpg", "1984" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Description", "DiscountPercent", "HoverImageUrl", "MainImageUrl", "Name", "Price" },
                values: new object[] { 4, "A romantic novel of manners", 20, "pride-prejudice-hover.jpg", "pride-prejudice.jpg", "Pride and Prejudice", 12.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Description", "DiscountPercent", "HoverImageUrl", "MainImageUrl", "Name", "Price" },
                values: new object[] { 5, "A classic American adventure novel", 5, "huckleberry-finn-hover.jpg", "huckleberry-finn.jpg", "Adventures of Huckleberry Finn", 13.50m });
        }
    }
}
