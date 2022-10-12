using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class migrationn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "128d730a-0ac8-4d57-803a-f1ab25c5b419");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d4431d2-2f27-4cb0-aca1-2ff2f407221d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de659f41-85a5-402f-969d-ace16a20242b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c034caf-ba1b-4a20-9c5f-57efc6307ed2", "e236ebe8-2076-4244-8f4f-dbe07a6e8ba5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6d36c8a-e15a-4698-b0bc-f8549574115a", "b920d5be-b9e0-4c45-8726-88162b41f341", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecc1ce2b-c9db-41bf-924f-3528eb01b717", "59b731de-f625-4ce0-b309-35bdc918237b", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c034caf-ba1b-4a20-9c5f-57efc6307ed2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6d36c8a-e15a-4698-b0bc-f8549574115a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecc1ce2b-c9db-41bf-924f-3528eb01b717");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "128d730a-0ac8-4d57-803a-f1ab25c5b419", "4fca0193-3bf3-4ec5-a9e7-ecaa6ce2d85c", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d4431d2-2f27-4cb0-aca1-2ff2f407221d", "bb681921-f148-439c-883c-1ae34d2fe193", "Manager", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de659f41-85a5-402f-969d-ace16a20242b", "885036fd-e9ff-4ff3-9ece-cdce1ada7aa3", "Manager", null });
        }
    }
}
