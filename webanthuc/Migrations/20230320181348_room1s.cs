using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webanthuc.Migrations
{
    public partial class room1s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room1_typeRooms_Id_TypeRoom",
                table: "Room1");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDetail_Room1_Id_Rooms1",
                table: "RoomDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room1",
                table: "Room1");

            migrationBuilder.RenameTable(
                name: "Room1",
                newName: "room1s");

            migrationBuilder.RenameIndex(
                name: "IX_Room1_Id_TypeRoom",
                table: "room1s",
                newName: "IX_room1s_Id_TypeRoom");

            migrationBuilder.AddPrimaryKey(
                name: "PK_room1s",
                table: "room1s",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_room1s_typeRooms_Id_TypeRoom",
                table: "room1s",
                column: "Id_TypeRoom",
                principalTable: "typeRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDetail_room1s_Id_Rooms1",
                table: "RoomDetail",
                column: "Id_Rooms1",
                principalTable: "room1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_room1s_typeRooms_Id_TypeRoom",
                table: "room1s");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDetail_room1s_Id_Rooms1",
                table: "RoomDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_room1s",
                table: "room1s");

            migrationBuilder.RenameTable(
                name: "room1s",
                newName: "Room1");

            migrationBuilder.RenameIndex(
                name: "IX_room1s_Id_TypeRoom",
                table: "Room1",
                newName: "IX_Room1_Id_TypeRoom");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room1",
                table: "Room1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room1_typeRooms_Id_TypeRoom",
                table: "Room1",
                column: "Id_TypeRoom",
                principalTable: "typeRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDetail_Room1_Id_Rooms1",
                table: "RoomDetail",
                column: "Id_Rooms1",
                principalTable: "Room1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
