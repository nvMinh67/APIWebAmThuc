using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class AddTbimage_dish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Dish",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "images_dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDish = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images_dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_images_dishes_Dish_IdDish",
                        column: x => x.IdDish,
                        principalTable: "Dish",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dish_DishId",
                table: "Dish",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_images_dishes_IdDish",
                table: "images_dishes",
                column: "IdDish");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Dish_DishId",
                table: "Dish",
                column: "DishId",
                principalTable: "Dish",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Dish_DishId",
                table: "Dish");

            migrationBuilder.DropTable(
                name: "images_dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dish_DishId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Dish");
        }
    }
}
