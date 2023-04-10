using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class ward : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Ward_id_Ward",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Ward_Districts_id_District",
                table: "Ward");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ward",
                table: "Ward");

            migrationBuilder.RenameTable(
                name: "Ward",
                newName: "Wards");

            migrationBuilder.RenameIndex(
                name: "IX_Ward_id_District",
                table: "Wards",
                newName: "IX_Wards_id_District");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wards",
                table: "Wards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Wards_id_Ward",
                table: "Contacts",
                column: "id_Ward",
                principalTable: "Wards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Districts_id_District",
                table: "Wards",
                column: "id_District",
                principalTable: "Districts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Wards_id_Ward",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Districts_id_District",
                table: "Wards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wards",
                table: "Wards");

            migrationBuilder.RenameTable(
                name: "Wards",
                newName: "Ward");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_id_District",
                table: "Ward",
                newName: "IX_Ward_id_District");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ward",
                table: "Ward",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Ward_id_Ward",
                table: "Contacts",
                column: "id_Ward",
                principalTable: "Ward",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ward_Districts_id_District",
                table: "Ward",
                column: "id_District",
                principalTable: "Districts",
                principalColumn: "Id");
        }
    }
}
