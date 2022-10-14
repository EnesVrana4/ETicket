using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class CatAndEventUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1390bf87-d05d-4963-a482-e067286eb97a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a370be15-614b-4aa7-9de8-63435d197502");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b365b466-be59-46b6-a193-b49dfe67301c");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1390bf87-d05d-4963-a482-e067286eb97a", "cd24ce7f-e6a0-4447-9870-8d0029b80463", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a370be15-614b-4aa7-9de8-63435d197502", "a5341db9-cf0f-4114-bad6-447946b0c754", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b365b466-be59-46b6-a193-b49dfe67301c", "482d9869-bce6-4d5e-842c-7be2fd8719d0", "User", "USER" });
        }
    }
}
