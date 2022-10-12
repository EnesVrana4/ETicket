using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class MigF : Migration
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
                values: new object[] { "0fb90c26-bb17-4124-b8aa-0eeb782a8bde", "079e6926-0c5c-4715-91e2-33ac6dd29eea", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3801fe31-6a55-4729-9026-6508e0973019", "326ca743-909a-41b8-9997-c379713ab1e6", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3079701-4451-496a-b1e5-9e23f17e77a1", "8cb520cf-16cf-400c-b4de-f8bb17e9d375", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fb90c26-bb17-4124-b8aa-0eeb782a8bde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3801fe31-6a55-4729-9026-6508e0973019");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3079701-4451-496a-b1e5-9e23f17e77a1");

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
