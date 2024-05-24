using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF2First.Migrations
{
    /// <inheritdoc />
    public partial class C3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "joindate",
                table: "author",
                newName: "Joindate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Joindate",
                table: "author",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Joindate",
                table: "author",
                newName: "joindate");

            migrationBuilder.AlterColumn<string>(
                name: "joindate",
                table: "author",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
