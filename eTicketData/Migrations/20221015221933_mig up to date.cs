using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class miguptodate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4abcc7a6-22ee-45ee-8009-410eaa04a6ba");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "781124a1-9411-49c7-84e5-723cc88cee4d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cbb79542-7847-4bea-b891-758815e9ed4b");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c8aaea3-03a2-44f4-8d6f-2ad5abd4573c", "4635f141-8599-46d2-9b2e-bbe8c64e7ba1", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4479df0a-914f-4a66-8afe-222d26dafe4f", "fc2c2b6b-318e-46c2-8264-28deb1cb0e5e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1da925b-8976-4a78-b004-7d185d6572c9", "b13a9aeb-3dd5-4355-b870-ba6475d0c0ed", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1c8aaea3-03a2-44f4-8d6f-2ad5abd4573c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4479df0a-914f-4a66-8afe-222d26dafe4f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b1da925b-8976-4a78-b004-7d185d6572c9");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4abcc7a6-22ee-45ee-8009-410eaa04a6ba", "ccb0ebe0-f42f-4b1d-b46f-e3fb3f488f9b", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "781124a1-9411-49c7-84e5-723cc88cee4d", "72f4df81-8229-4e3c-9da1-eea969300eb7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbb79542-7847-4bea-b891-758815e9ed4b", "2b8c1aa3-42bc-40e2-808c-91c364c8da9d", "User", "USER" });
        }
    }
}
