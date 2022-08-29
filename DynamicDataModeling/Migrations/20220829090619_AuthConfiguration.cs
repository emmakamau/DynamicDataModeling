using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicDataModeling.Migrations
{
    public partial class AuthConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "GlobalTypes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "GlobalTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Text Field");

            migrationBuilder.UpdateData(
                table: "GlobalTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "TextField");

            migrationBuilder.UpdateData(
                table: "GlobalTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "TextField");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "GlobalTypes");
        }
    }
}
