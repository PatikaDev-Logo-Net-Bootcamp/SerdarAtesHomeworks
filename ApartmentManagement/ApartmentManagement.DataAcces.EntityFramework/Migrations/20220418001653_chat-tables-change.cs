using Microsoft.EntityFrameworkCore.Migrations;

namespace ApartmentManagement.DataAcces.EntityFramework.Migrations
{
    public partial class chattableschange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "SendTime",
                schema: "dbo",
                table: "Messages",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "FromUserId",
                schema: "dbo",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToUserId",
                schema: "dbo",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUserId",
                schema: "dbo",
                table: "Messages",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUserId",
                schema: "dbo",
                table: "Messages",
                column: "ToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_FromUserId",
                schema: "dbo",
                table: "Messages",
                column: "FromUserId",
                principalSchema: "dbo",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ToUserId",
                schema: "dbo",
                table: "Messages",
                column: "ToUserId",
                principalSchema: "dbo",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_FromUserId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ToUserId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUserId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToUserId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "FromUserId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ToUserId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "Messages",
                newName: "SendTime");

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                schema: "dbo",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverId",
                schema: "dbo",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                schema: "dbo",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
