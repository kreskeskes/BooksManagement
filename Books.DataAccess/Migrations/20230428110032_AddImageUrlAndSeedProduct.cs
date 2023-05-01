using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlAndSeedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "ISBN", "Title" },
                values: new object[] { "Harper Lee", "9780446310789", "To Kill a Mockingbird" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "ISBN", "Title" },
                values: new object[] { "F. Scott Fitzgerald", "9780743273565", "The Great Gatsby" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CategoryId", "ISBN", "Title" },
                values: new object[] { "George Orwell", 3, "9780451524935", "1984" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CategoryId", "ISBN", "Title" },
                values: new object[] { "J.D. Salinger", 2, "9780316769488", "The Catcher in the Rye" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "ISBN", "Title" },
                values: new object[] { "Jane Austen", "9780141439518", "Pride and Prejudice" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "Title" },
                values: new object[] { "Author: J.R.R. Tolkien", 1, "The Lord of the Rings" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "ISBN", "Title" },
                values: new object[] { "Billy Spark", "SWD9999001", "Fortune of Time" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "ISBN", "Title" },
                values: new object[] { "Nancy Hoover", "CAW777777701", "Dark Skies" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "CategoryId", "ISBN", "Title" },
                values: new object[] { "Julian Button", 1, "RITO5555501", "Vanish in the Sunset" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CategoryId", "ISBN", "Title" },
                values: new object[] { "Abby Muscles", 1, "WS3333333301", "Cotton Candy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "ISBN", "Title" },
                values: new object[] { "Ron Parker", "SOTJ1111111101", "Rock in the Ocean" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "Title" },
                values: new object[] { "Laura Phantom", 2, "Leaves and Wonders" });
        }
    }
}
