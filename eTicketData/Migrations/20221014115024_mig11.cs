using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class mig11 : Migration
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
                values: new object[] { "0e253eb2-a442-4d45-bd46-53243b2673c2", "4e1883a4-e53b-4119-88f2-0113d3b9931f", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b89d000-c1ec-4704-94e3-576419f8284c", "e1ff70bc-95f2-45a1-953d-d95b1c01936f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1586ddd-d56e-4ecd-b1f8-56214021a3be", "3863c88b-89f9-45a2-8575-c97b922794ce", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0e253eb2-a442-4d45-bd46-53243b2673c2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8b89d000-c1ec-4704-94e3-576419f8284c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e1586ddd-d56e-4ecd-b1f8-56214021a3be");

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
