using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "17fc7433-cb0e-4cdf-9c77-05c336f10145");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4abcc7a6-22ee-45ee-8009-410eaa04a6ba");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cbb79542-7847-4bea-b891-758815e9ed4b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "17fc7433-cb0e-4cdf-9c77-05c336f10145", "381ee5fb-a41a-4abc-9373-4eec19ee1289", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4abcc7a6-22ee-45ee-8009-410eaa04a6ba", "ccb0ebe0-f42f-4b1d-b46f-e3fb3f488f9b", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbb79542-7847-4bea-b891-758815e9ed4b", "2b8c1aa3-42bc-40e2-808c-91c364c8da9d", "User", "USER" });
        }
    }
}
