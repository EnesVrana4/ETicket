using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class CategoryTicketPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "35811647-a7ce-41b9-a126-031335aceb31");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3830366f-91ce-4fa9-b43e-dcfc7f039f37");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b258213b-2a27-4c56-94a8-d17d9d2dd53b");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Categorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Categorys");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35811647-a7ce-41b9-a126-031335aceb31", "f07c9ae9-9a8f-4d29-a70d-92bf5010223f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3830366f-91ce-4fa9-b43e-dcfc7f039f37", "ffd125d8-1c20-4279-8fb0-fdcf77e8bd87", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b258213b-2a27-4c56-94a8-d17d9d2dd53b", "b53e0c92-8972-49fb-a654-aedc01e49e0d", "Manager", "MANAGER" });
        }
    }
}
