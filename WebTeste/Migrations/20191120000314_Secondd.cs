using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTeste.Migrations
{
    public partial class Secondd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Sellers_SellersId",
                table: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_SellersId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "SellersId",
                table: "SalesRecord");

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "SalesRecord",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecord",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Sellers_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Sellers_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "SalesRecord");

            migrationBuilder.AddColumn<int>(
                name: "SellersId",
                table: "SalesRecord",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_SellersId",
                table: "SalesRecord",
                column: "SellersId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Sellers_SellersId",
                table: "SalesRecord",
                column: "SellersId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
