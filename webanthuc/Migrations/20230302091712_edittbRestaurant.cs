using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class edittbRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menus_restaurants_id_restaurant",
                table: "menus");

            migrationBuilder.AlterColumn<int>(
                name: "id_restaurant",
                table: "menus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_menus_restaurants_id_restaurant",
                table: "menus",
                column: "id_restaurant",
                principalTable: "restaurants",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menus_restaurants_id_restaurant",
                table: "menus");

            migrationBuilder.AlterColumn<int>(
                name: "id_restaurant",
                table: "menus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_menus_restaurants_id_restaurant",
                table: "menus",
                column: "id_restaurant",
                principalTable: "restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
