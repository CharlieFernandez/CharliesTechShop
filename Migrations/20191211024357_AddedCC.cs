using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondCharliesTechShop.Migrations
{
    public partial class AddedCC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CCNumber",
                table: "Orders",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CCNumber",
                table: "Orders");
        }
    }
}
