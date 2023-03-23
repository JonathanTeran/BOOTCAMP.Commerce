using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Persistence.Database.Migrations
{
    /// <inheritdoc />
    public partial class CatalogInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductInStocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInStocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_ProductInStocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 126 },
                    { 2, "Description for product 2", "Product 2", 132 },
                    { 3, "Description for product 3", "Product 3", 742 },
                    { 4, "Description for product 4", "Product 4", 809 },
                    { 5, "Description for product 5", "Product 5", 862 },
                    { 6, "Description for product 6", "Product 6", 951 },
                    { 7, "Description for product 7", "Product 7", 987 },
                    { 8, "Description for product 8", "Product 8", 404 },
                    { 9, "Description for product 9", "Product 9", 468 },
                    { 10, "Description for product 10", "Product 10", 566 },
                    { 11, "Description for product 11", "Product 11", 713 },
                    { 12, "Description for product 12", "Product 12", 928 },
                    { 13, "Description for product 13", "Product 13", 560 },
                    { 14, "Description for product 14", "Product 14", 960 },
                    { 15, "Description for product 15", "Product 15", 451 },
                    { 16, "Description for product 16", "Product 16", 287 },
                    { 17, "Description for product 17", "Product 17", 379 },
                    { 18, "Description for product 18", "Product 18", 669 },
                    { 19, "Description for product 19", "Product 19", 499 },
                    { 20, "Description for product 20", "Product 20", 395 },
                    { 21, "Description for product 21", "Product 21", 380 },
                    { 22, "Description for product 22", "Product 22", 145 },
                    { 23, "Description for product 23", "Product 23", 730 },
                    { 24, "Description for product 24", "Product 24", 364 },
                    { 25, "Description for product 25", "Product 25", 596 },
                    { 26, "Description for product 26", "Product 26", 875 },
                    { 27, "Description for product 27", "Product 27", 891 },
                    { 28, "Description for product 28", "Product 28", 366 },
                    { 29, "Description for product 29", "Product 29", 908 },
                    { 30, "Description for product 30", "Product 30", 681 },
                    { 31, "Description for product 31", "Product 31", 806 },
                    { 32, "Description for product 32", "Product 32", 509 },
                    { 33, "Description for product 33", "Product 33", 806 },
                    { 34, "Description for product 34", "Product 34", 780 },
                    { 35, "Description for product 35", "Product 35", 821 },
                    { 36, "Description for product 36", "Product 36", 478 },
                    { 37, "Description for product 37", "Product 37", 232 },
                    { 38, "Description for product 38", "Product 38", 244 },
                    { 39, "Description for product 39", "Product 39", 807 },
                    { 40, "Description for product 40", "Product 40", 480 },
                    { 41, "Description for product 41", "Product 41", 611 },
                    { 42, "Description for product 42", "Product 42", 210 },
                    { 43, "Description for product 43", "Product 43", 266 },
                    { 44, "Description for product 44", "Product 44", 535 },
                    { 45, "Description for product 45", "Product 45", 828 },
                    { 46, "Description for product 46", "Product 46", 548 },
                    { 47, "Description for product 47", "Product 47", 982 },
                    { 48, "Description for product 48", "Product 48", 920 },
                    { 49, "Description for product 49", "Product 49", 210 },
                    { 50, "Description for product 50", "Product 50", 204 },
                    { 51, "Description for product 51", "Product 51", 363 },
                    { 52, "Description for product 52", "Product 52", 557 },
                    { 53, "Description for product 53", "Product 53", 288 },
                    { 54, "Description for product 54", "Product 54", 267 },
                    { 55, "Description for product 55", "Product 55", 659 },
                    { 56, "Description for product 56", "Product 56", 812 },
                    { 57, "Description for product 57", "Product 57", 883 },
                    { 58, "Description for product 58", "Product 58", 447 },
                    { 59, "Description for product 59", "Product 59", 842 },
                    { 60, "Description for product 60", "Product 60", 168 },
                    { 61, "Description for product 61", "Product 61", 207 },
                    { 62, "Description for product 62", "Product 62", 199 },
                    { 63, "Description for product 63", "Product 63", 896 },
                    { 64, "Description for product 64", "Product 64", 754 },
                    { 65, "Description for product 65", "Product 65", 833 },
                    { 66, "Description for product 66", "Product 66", 928 },
                    { 67, "Description for product 67", "Product 67", 146 },
                    { 68, "Description for product 68", "Product 68", 692 },
                    { 69, "Description for product 69", "Product 69", 333 },
                    { 70, "Description for product 70", "Product 70", 815 },
                    { 71, "Description for product 71", "Product 71", 262 },
                    { 72, "Description for product 72", "Product 72", 999 },
                    { 73, "Description for product 73", "Product 73", 381 },
                    { 74, "Description for product 74", "Product 74", 404 },
                    { 75, "Description for product 75", "Product 75", 753 },
                    { 76, "Description for product 76", "Product 76", 431 },
                    { 77, "Description for product 77", "Product 77", 442 },
                    { 78, "Description for product 78", "Product 78", 708 },
                    { 79, "Description for product 79", "Product 79", 878 },
                    { 80, "Description for product 80", "Product 80", 880 },
                    { 81, "Description for product 81", "Product 81", 455 },
                    { 82, "Description for product 82", "Product 82", 328 },
                    { 83, "Description for product 83", "Product 83", 470 },
                    { 84, "Description for product 84", "Product 84", 364 },
                    { 85, "Description for product 85", "Product 85", 602 },
                    { 86, "Description for product 86", "Product 86", 655 },
                    { 87, "Description for product 87", "Product 87", 860 },
                    { 88, "Description for product 88", "Product 88", 968 },
                    { 89, "Description for product 89", "Product 89", 614 },
                    { 90, "Description for product 90", "Product 90", 555 },
                    { 91, "Description for product 91", "Product 91", 506 },
                    { 92, "Description for product 92", "Product 92", 161 },
                    { 93, "Description for product 93", "Product 93", 840 },
                    { 94, "Description for product 94", "Product 94", 196 },
                    { 95, "Description for product 95", "Product 95", 106 },
                    { 96, "Description for product 96", "Product 96", 130 },
                    { 97, "Description for product 97", "Product 97", 651 },
                    { 98, "Description for product 98", "Product 98", 660 },
                    { 99, "Description for product 99", "Product 99", 264 },
                    { 100, "Description for product 100", "Product 100", 672 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "ProductInStocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 19 },
                    { 2, 2, 6 },
                    { 3, 3, 39 },
                    { 4, 4, 37 },
                    { 5, 5, 15 },
                    { 6, 6, 36 },
                    { 7, 7, 31 },
                    { 8, 8, 34 },
                    { 9, 9, 15 },
                    { 10, 10, 22 },
                    { 11, 11, 14 },
                    { 12, 12, 39 },
                    { 13, 13, 37 },
                    { 14, 14, 11 },
                    { 15, 15, 12 },
                    { 16, 16, 26 },
                    { 17, 17, 27 },
                    { 18, 18, 11 },
                    { 19, 19, 25 },
                    { 20, 20, 24 },
                    { 21, 21, 5 },
                    { 22, 22, 34 },
                    { 23, 23, 2 },
                    { 24, 24, 9 },
                    { 25, 25, 3 },
                    { 26, 26, 11 },
                    { 27, 27, 3 },
                    { 28, 28, 11 },
                    { 29, 29, 23 },
                    { 30, 30, 6 },
                    { 31, 31, 32 },
                    { 32, 32, 38 },
                    { 33, 33, 36 },
                    { 34, 34, 31 },
                    { 35, 35, 19 },
                    { 36, 36, 33 },
                    { 37, 37, 4 },
                    { 38, 38, 23 },
                    { 39, 39, 33 },
                    { 40, 40, 2 },
                    { 41, 41, 5 },
                    { 42, 42, 2 },
                    { 43, 43, 19 },
                    { 44, 44, 22 },
                    { 45, 45, 0 },
                    { 46, 46, 1 },
                    { 47, 47, 21 },
                    { 48, 48, 4 },
                    { 49, 49, 7 },
                    { 50, 50, 12 },
                    { 51, 51, 31 },
                    { 52, 52, 5 },
                    { 53, 53, 17 },
                    { 54, 54, 19 },
                    { 55, 55, 17 },
                    { 56, 56, 13 },
                    { 57, 57, 36 },
                    { 58, 58, 11 },
                    { 59, 59, 11 },
                    { 60, 60, 39 },
                    { 61, 61, 1 },
                    { 62, 62, 34 },
                    { 63, 63, 27 },
                    { 64, 64, 2 },
                    { 65, 65, 25 },
                    { 66, 66, 13 },
                    { 67, 67, 22 },
                    { 68, 68, 28 },
                    { 69, 69, 37 },
                    { 70, 70, 20 },
                    { 71, 71, 23 },
                    { 72, 72, 12 },
                    { 73, 73, 24 },
                    { 74, 74, 5 },
                    { 75, 75, 31 },
                    { 76, 76, 7 },
                    { 77, 77, 32 },
                    { 78, 78, 31 },
                    { 79, 79, 23 },
                    { 80, 80, 23 },
                    { 81, 81, 1 },
                    { 82, 82, 30 },
                    { 83, 83, 11 },
                    { 84, 84, 24 },
                    { 85, 85, 27 },
                    { 86, 86, 16 },
                    { 87, 87, 5 },
                    { 88, 88, 4 },
                    { 89, 89, 32 },
                    { 90, 90, 33 },
                    { 91, 91, 1 },
                    { 92, 92, 33 },
                    { 93, 93, 20 },
                    { 94, 94, 28 },
                    { 95, 95, 28 },
                    { 96, 96, 32 },
                    { 97, 97, 30 },
                    { 98, 98, 35 },
                    { 99, 99, 11 },
                    { 100, 100, 26 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInStocks_ProductId",
                schema: "Catalog",
                table: "ProductInStocks",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInStocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
