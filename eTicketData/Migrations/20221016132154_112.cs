using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class _112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1aaf6b79-39db-4270-89b1-9c4e5b88fa61", "932a4eef-2538-4ec2-81db-32d62ad318d6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4caa600e-53ba-442a-8fa2-762acaf59120", "0a0e511c-25ab-475f-830b-aff6b80d82bf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c656aad5-9803-4c84-8c52-aa3719b19b11", "54990797-0175-4ad6-913c-101ca613f97a", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1aaf6b79-39db-4270-89b1-9c4e5b88fa61");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4caa600e-53ba-442a-8fa2-762acaf59120");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c656aad5-9803-4c84-8c52-aa3719b19b11");

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
    }
}
