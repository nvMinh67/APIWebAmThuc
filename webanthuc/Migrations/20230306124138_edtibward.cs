using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class edtibward : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ward_Districts_id_Dishtrict",
                table: "Ward");

            migrationBuilder.DropIndex(
                name: "IX_Ward_id_Dishtrict",
                table: "Ward");

            migrationBuilder.DropColumn(
                name: "id_Dishtrict",
                table: "Ward");

            migrationBuilder.CreateIndex(
                name: "IX_Ward_id_District",
                table: "Ward",
                column: "id_District");

            migrationBuilder.AddForeignKey(
                name: "FK_Ward_Districts_id_District",
                table: "Ward",
                column: "id_District",
                principalTable: "Districts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ward_Districts_id_District",
                table: "Ward");

            migrationBuilder.DropIndex(
                name: "IX_Ward_id_District",
                table: "Ward");

            migrationBuilder.AddColumn<int>(
                name: "id_Dishtrict",
                table: "Ward",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ward_id_Dishtrict",
                table: "Ward",
                column: "id_Dishtrict");

            migrationBuilder.AddForeignKey(
                name: "FK_Ward_Districts_id_Dishtrict",
                table: "Ward",
                column: "id_Dishtrict",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
