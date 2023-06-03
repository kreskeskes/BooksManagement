using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.DataAccess.Migrations
{
	/// <inheritdoc />
	public partial class addOrderHeaderAndDetailsToDb : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "Products",
				keyColumn: "Id",
				keyValue: 6);

			migrationBuilder.CreateTable(
				name: "OrderHeaders",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					OrderTotal = table.Column<double>(type: "float", nullable: false),
					OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
					TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					PaymentIntentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
					City = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PhoneNumber = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_OrderHeaders", x => x.Id);
					table.ForeignKey(
						name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
						column: x => x.ApplicationUserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "OrderDetails",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					OrderHeaderId = table.Column<int>(type: "int", nullable: false),
					ProductId = table.Column<int>(type: "int", nullable: false),
					Count = table.Column<int>(type: "int", nullable: false),
					Price = table.Column<double>(type: "float", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_OrderDetails", x => x.Id);
					table.ForeignKey(
						name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
						column: x => x.OrderHeaderId,
						principalTable: "OrderHeaders",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_OrderDetails_Products_ProductId",
						column: x => x.ProductId,
						principalTable: "Products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

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

			migrationBuilder.CreateIndex(
				name: "IX_OrderDetails_OrderHeaderId",
				table: "OrderDetails",
				column: "OrderHeaderId");

			migrationBuilder.CreateIndex(
				name: "IX_OrderDetails_ProductId",
				table: "OrderDetails",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_OrderHeaders_ApplicationUserId",
				table: "OrderHeaders",
				column: "ApplicationUserId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "OrderDetails");

			migrationBuilder.DropTable(
				name: "OrderHeaders");

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

			migrationBuilder.InsertData(
				table: "Products",
				columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
				values: new object[] { 6, "Laura Phantom", 2, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" });
		}
	}
}
