using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class AddDish2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menus_Dish_id_dish",
                table: "menus");

            migrationBuilder.AlterColumn<int>(
                name: "id_dish",
                table: "menus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Dish1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image_Dish1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDish1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image_Dish1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Dish1s_Dish1_IdDish1",
                        column: x => x.IdDish1,
                        principalTable: "Dish1",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_Dish1s_IdDish1",
                table: "Image_Dish1s",
                column: "IdDish1");

            migrationBuilder.AddForeignKey(
                name: "FK_menus_Dish_id_dish",
                table: "menus",
                column: "id_dish",
                principalTable: "Dish",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menus_Dish_id_dish",
                table: "menus");

            migrationBuilder.DropTable(
                name: "Image_Dish1s");

            migrationBuilder.DropTable(
                name: "Dish1");

            migrationBuilder.AlterColumn<int>(
                name: "id_dish",
                table: "menus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_menus_Dish_id_dish",
                table: "menus",
                column: "id_dish",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
