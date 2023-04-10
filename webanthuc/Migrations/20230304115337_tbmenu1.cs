using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class tbmenu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "menus1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_restaurant1 = table.Column<int>(type: "int", nullable: true),
                    id_dish1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menus1_Dish1_id_dish1",
                        column: x => x.id_dish1,
                        principalTable: "Dish1",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_menus1_Restaurants1_id_restaurant1",
                        column: x => x.id_restaurant1,
                        principalTable: "Restaurants1",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_menus1_id_dish1",
                table: "menus1",
                column: "id_dish1");

            migrationBuilder.CreateIndex(
                name: "IX_menus1_id_restaurant1",
                table: "menus1",
                column: "id_restaurant1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menus1");
        }
    }
}
