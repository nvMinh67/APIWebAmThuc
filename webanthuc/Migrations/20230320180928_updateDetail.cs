using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class updateDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomDetail_rooms_Id_Rooms",
                table: "RoomDetail");

            migrationBuilder.RenameColumn(
                name: "Id_Rooms",
                table: "RoomDetail",
                newName: "Id_Rooms1");

            migrationBuilder.RenameIndex(
                name: "IX_RoomDetail_Id_Rooms",
                table: "RoomDetail",
                newName: "IX_RoomDetail_Id_Rooms1");

            migrationBuilder.AddColumn<int>(
                name: "Id_Room1s",
                table: "RoomDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Room1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_TypeRoom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room1_typeRooms_Id_TypeRoom",
                        column: x => x.Id_TypeRoom,
                        principalTable: "typeRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room1_Id_TypeRoom",
                table: "Room1",
                column: "Id_TypeRoom");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDetail_Room1_Id_Rooms1",
                table: "RoomDetail",
                column: "Id_Rooms1",
                principalTable: "Room1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomDetail_Room1_Id_Rooms1",
                table: "RoomDetail");

            migrationBuilder.DropTable(
                name: "Room1");

            migrationBuilder.DropColumn(
                name: "Id_Room1s",
                table: "RoomDetail");

            migrationBuilder.RenameColumn(
                name: "Id_Rooms1",
                table: "RoomDetail",
                newName: "Id_Rooms");

            migrationBuilder.RenameIndex(
                name: "IX_RoomDetail_Id_Rooms1",
                table: "RoomDetail",
                newName: "IX_RoomDetail_Id_Rooms");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDetail_rooms_Id_Rooms",
                table: "RoomDetail",
                column: "Id_Rooms",
                principalTable: "rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
