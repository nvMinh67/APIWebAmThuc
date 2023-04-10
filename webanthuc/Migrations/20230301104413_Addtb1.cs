using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class Addtb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menus_Dish_IdDish",
                table: "menus");

            migrationBuilder.DropForeignKey(
                name: "FK_menus_restaurants_IdRestaurant",
                table: "menus");

            migrationBuilder.DropIndex(
                name: "IX_menus_IdDish",
                table: "menus");

            migrationBuilder.DropIndex(
                name: "IX_menus_IdRestaurant",
                table: "menus");

            migrationBuilder.DropColumn(
                name: "IdDish",
                table: "menus");

            migrationBuilder.DropColumn(
                name: "IdRestaurant",
                table: "menus");

            migrationBuilder.CreateIndex(
                name: "IX_menus_id_dish",
                table: "menus",
                column: "id_dish");

            migrationBuilder.CreateIndex(
                name: "IX_menus_id_restaurant",
                table: "menus",
                column: "id_restaurant");

            migrationBuilder.AddForeignKey(
                name: "FK_menus_Dish_id_dish",
                table: "menus",
                column: "id_dish",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_menus_restaurants_id_restaurant",
                table: "menus",
                column: "id_restaurant",
                principalTable: "restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menus_Dish_id_dish",
                table: "menus");

            migrationBuilder.DropForeignKey(
                name: "FK_menus_restaurants_id_restaurant",
                table: "menus");

            migrationBuilder.DropIndex(
                name: "IX_menus_id_dish",
                table: "menus");

            migrationBuilder.DropIndex(
                name: "IX_menus_id_restaurant",
                table: "menus");

            migrationBuilder.AddColumn<int>(
                name: "IdDish",
                table: "menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRestaurant",
                table: "menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_menus_IdDish",
                table: "menus",
                column: "IdDish");

            migrationBuilder.CreateIndex(
                name: "IX_menus_IdRestaurant",
                table: "menus",
                column: "IdRestaurant");

            migrationBuilder.AddForeignKey(
                name: "FK_menus_Dish_IdDish",
                table: "menus",
                column: "IdDish",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_menus_restaurants_IdRestaurant",
                table: "menus",
                column: "IdRestaurant",
                principalTable: "restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
