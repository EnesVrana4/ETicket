using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class AddedRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
