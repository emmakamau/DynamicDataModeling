using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicDataModeling.Migrations
{
    public partial class Two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "GlobalTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalTypes_ContactId",
                table: "GlobalTypes",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalTypes_Contacts_ContactId",
                table: "GlobalTypes",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalTypes_Contacts_ContactId",
                table: "GlobalTypes");

            migrationBuilder.DropIndex(
                name: "IX_GlobalTypes_ContactId",
                table: "GlobalTypes");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "GlobalTypes");
        }
    }
}
