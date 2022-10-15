using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class NewMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8a9f6350-9af9-4fd7-88f1-c0cfeb1763d7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "95cccb04-026b-4691-aa1f-324d82ad8551");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ffcd38d2-cbbc-432e-a9c0-98163fb49b37");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c16573c-cf55-4839-98d2-2437f1d3e9dc", "8d331b6c-b497-40c8-aacb-00e393c25daa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "781124a1-9411-49c7-84e5-723cc88cee4d", "72f4df81-8229-4e3c-9da1-eea969300eb7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eec2f77d-1005-439b-abc6-0b81cfde22b1", "d7bce3a4-67c2-444c-ab70-53a37b99ca57", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c16573c-cf55-4839-98d2-2437f1d3e9dc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "781124a1-9411-49c7-84e5-723cc88cee4d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "eec2f77d-1005-439b-abc6-0b81cfde22b1");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a9f6350-9af9-4fd7-88f1-c0cfeb1763d7", "89db96d4-d561-4299-b766-82175a7509a7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95cccb04-026b-4691-aa1f-324d82ad8551", "a26197df-8fd7-4e1c-96ab-61e975a558fb", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffcd38d2-cbbc-432e-a9c0-98163fb49b37", "c0a02980-8f89-4fe2-a13d-5e3baccc827b", "User", "USER" });
        }
    }
}
