using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApartmentManagement.DataAcces.EntityFramework.Migrations
{
    public partial class updatedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "dbo",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "Type",
                schema: "dbo",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "content",
                schema: "dbo",
                table: "Messages",
                newName: "Content");

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                schema: "dbo",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReceiverId",
                schema: "dbo",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "SendTime",
                schema: "dbo",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsOwner",
                schema: "dbo",
                table: "Flats",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendTime",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsOwner",
                schema: "dbo",
                table: "Flats");

            migrationBuilder.RenameColumn(
                name: "Content",
                schema: "dbo",
                table: "Messages",
                newName: "content");

            migrationBuilder.AlterColumn<int>(
                name: "SenderId",
                schema: "dbo",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceiverId",
                schema: "dbo",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                schema: "dbo",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
