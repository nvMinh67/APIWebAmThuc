using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class Addtb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Dish_DishId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_DishId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Dish");

            migrationBuilder.CreateTable(
                name: "restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mapdata = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    about = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image_Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRestaurant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Restaurants_restaurants_IdRestaurant",
                        column: x => x.IdRestaurant,
                        principalTable: "restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_restaurant = table.Column<int>(type: "int", nullable: false),
                    IdRestaurant = table.Column<int>(type: "int", nullable: false),
                    id_dish = table.Column<int>(type: "int", nullable: false),
                    IdDish = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menus_Dish_IdDish",
                        column: x => x.IdDish,
                        principalTable: "Dish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_menus_restaurants_IdRestaurant",
                        column: x => x.IdRestaurant,
                        principalTable: "restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_Restaurants_IdRestaurant",
                table: "Image_Restaurants",
                column: "IdRestaurant");

            migrationBuilder.CreateIndex(
                name: "IX_menus_IdDish",
                table: "menus",
                column: "IdDish");

            migrationBuilder.CreateIndex(
                name: "IX_menus_IdRestaurant",
                table: "menus",
                column: "IdRestaurant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image_Restaurants");

            migrationBuilder.DropTable(
                name: "menus");

            migrationBuilder.DropTable(
                name: "restaurants");

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Dish",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_DishId",
                table: "Dish",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Dish_DishId",
                table: "Dish",
                column: "DishId",
                principalTable: "Dish",
                principalColumn: "Id");
        }
    }
}
