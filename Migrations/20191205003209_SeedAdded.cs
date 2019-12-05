using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondCharliesTechShop.Migrations
{
    public partial class SeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Laptops", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Computer Mice", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Mouse Pads", null });

            migrationBuilder.InsertData(
                table: "Tech",
                columns: new[] { "TechId", "CategoryId", "ImageUrl", "InStock", "Name", "PopularTech", "Price" },
                values: new object[,]
                {
                    { 1, 1, "https://images-na.ssl-images-amazon.com/images/I/81H9y1pPW6L._AC_SL1500_.jpg", true, "Acer Laptop", true, 799.99m },
                    { 2, 2, "https://images-na.ssl-images-amazon.com/images/I/61d9C4yCB2L._AC_SL1000_.jpg", true, "PICTEK Gaming Mouse", false, 15.29m },
                    { 4, 2, "https://images-na.ssl-images-amazon.com/images/I/81ZQgWwuVzL._AC_SL1500_.jpg", true, "Logitech G602 Mouse", false, 24.99m },
                    { 3, 3, "https://images-na.ssl-images-amazon.com/images/I/51Wf5oBCB1L._AC_SL1000_.jpg", true, "Teemo Mouse Pad", false, 10.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tech",
                keyColumn: "TechId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tech",
                keyColumn: "TechId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tech",
                keyColumn: "TechId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tech",
                keyColumn: "TechId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
