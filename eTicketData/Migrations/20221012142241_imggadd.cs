using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class imggadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46d7ab75-2c85-4025-923f-c6635b9fed5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57ff3858-b7e2-48a5-9cd9-1c9694acf056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "994082d2-07bf-4969-9a6c-87d061ec99fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03e8b2b8-d766-4fde-a0da-bf40b31a21c4", "04a2003f-7a90-4f60-bf19-05d386780e9c", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b602451-8b9e-4fa3-9bab-180f8a95524c", "a9a66029-20c7-42d4-adc1-7d3bc134bff2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90399a34-36db-431b-adbc-9403964cc5f7", "2c25476f-482c-454a-9f68-ac046b09a069", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03e8b2b8-d766-4fde-a0da-bf40b31a21c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b602451-8b9e-4fa3-9bab-180f8a95524c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90399a34-36db-431b-adbc-9403964cc5f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46d7ab75-2c85-4025-923f-c6635b9fed5d", "33adeb14-cebb-4d48-b4ea-5941844e269f", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57ff3858-b7e2-48a5-9cd9-1c9694acf056", "6548aa60-daac-4d61-b50f-c1cbd650d316", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "994082d2-07bf-4969-9a6c-87d061ec99fb", "00a37cd4-52a1-46d4-b3e5-e52f1cef018c", "User", "USER" });
        }
    }
}
