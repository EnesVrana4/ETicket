using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class fr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "30fc6a74-28e6-4fa6-83cb-2bf41687862a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7bc3d2c6-eb63-4482-adb7-2c3a130f9c16");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6ac13af-bd40-41c9-9f52-64f373075a48");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "30fc6a74-28e6-4fa6-83cb-2bf41687862a", "601c1841-db93-45e8-8016-8a9e761622dd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bc3d2c6-eb63-4482-adb7-2c3a130f9c16", "d9444425-9311-41ac-b705-4957c8d7a319", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6ac13af-bd40-41c9-9f52-64f373075a48", "99799059-f696-4f60-b48e-a6076d2b70a5", "Manager", "MANAGER" });
        }
    }
}
