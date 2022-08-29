using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicDataModeling.Migrations
{
    public partial class Three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "GlobalTypes");

            migrationBuilder.DropColumn(
                name: "Field",
                table: "GlobalTypes");

            migrationBuilder.AddColumn<int>(
                name: "GlobalTypeId",
                table: "Contacts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "GlobalTypes",
                columns: new[] { "Id", "Name", "TableName" },
                values: new object[,]
                {
                    { 1, "PhoneNumber", "Contacts" },
                    { 2, "Fax", "Contacts" },
                    { 3, "Email", "Contacts" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "User1" },
                    { 2, "User2" },
                    { 3, "User3" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "GlobalTypeId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_GlobalTypeId",
                table: "Contacts",
                column: "GlobalTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_GlobalTypes_GlobalTypeId",
                table: "Contacts",
                column: "GlobalTypeId",
                principalTable: "GlobalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_GlobalTypes_GlobalTypeId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_GlobalTypeId",
                table: "Contacts");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GlobalTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GlobalTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GlobalTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "GlobalTypeId",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "GlobalTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GlobalTypes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Field",
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
    }
}
