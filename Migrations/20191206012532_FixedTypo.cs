using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondCharliesTechShop.Migrations
{
    public partial class FixedTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Tech_TechId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PieId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "TechId",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Tech_TechId",
                table: "OrderDetails",
                column: "TechId",
                principalTable: "Tech",
                principalColumn: "TechId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Tech_TechId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "TechId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PieId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Tech_TechId",
                table: "OrderDetails",
                column: "TechId",
                principalTable: "Tech",
                principalColumn: "TechId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
