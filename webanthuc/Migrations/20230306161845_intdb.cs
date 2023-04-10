using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class intdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailContacts_restaurants_id_Restaurant",
                table: "DetailContacts");

            migrationBuilder.RenameColumn(
                name: "id_Restaurant",
                table: "DetailContacts",
                newName: "id_Restaurant1");

            migrationBuilder.RenameIndex(
                name: "IX_DetailContacts_id_Restaurant",
                table: "DetailContacts",
                newName: "IX_DetailContacts_id_Restaurant1");

            migrationBuilder.CreateTable(
                name: "detailContact1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Contact = table.Column<int>(type: "int", nullable: true),
                    id_Restaurant1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detailContact1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detailContact1s_Contacts_id_Contact",
                        column: x => x.id_Contact,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detailContact1s_Restaurants1_id_Restaurant1",
                        column: x => x.id_Restaurant1,
                        principalTable: "Restaurants1",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_detailContact1s_id_Contact",
                table: "detailContact1s",
                column: "id_Contact");

            migrationBuilder.CreateIndex(
                name: "IX_detailContact1s_id_Restaurant1",
                table: "detailContact1s",
                column: "id_Restaurant1");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailContacts_Restaurants1_id_Restaurant1",
                table: "DetailContacts",
                column: "id_Restaurant1",
                principalTable: "Restaurants1",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailContacts_Restaurants1_id_Restaurant1",
                table: "DetailContacts");

            migrationBuilder.DropTable(
                name: "detailContact1s");

            migrationBuilder.RenameColumn(
                name: "id_Restaurant1",
                table: "DetailContacts",
                newName: "id_Restaurant");

            migrationBuilder.RenameIndex(
                name: "IX_DetailContacts_id_Restaurant1",
                table: "DetailContacts",
                newName: "IX_DetailContacts_id_Restaurant");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailContacts_restaurants_id_Restaurant",
                table: "DetailContacts",
                column: "id_Restaurant",
                principalTable: "restaurants",
                principalColumn: "Id");
        }
    }
}
