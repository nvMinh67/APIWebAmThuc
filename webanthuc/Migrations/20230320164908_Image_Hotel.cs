using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class Image_Hotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image_Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_Hotel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image_Hotel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Hotel_hotels_id_Hotel",
                        column: x => x.id_Hotel,
                        principalTable: "hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_Hotel_id_Hotel",
                table: "Image_Hotel",
                column: "id_Hotel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image_Hotel");
        }
    }
}
