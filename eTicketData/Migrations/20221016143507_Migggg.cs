using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class Migggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "59e7ff7b-7957-4d8c-9580-5eb50d1c15d6", "02b0cbb0-9b2a-4596-b29c-f0c2270d8699", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6f2a354-538f-4e89-9d56-81e078c79afc", "70c614cf-155a-4a08-b718-4104e9560ced", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e05b5fb9-09fe-4a8b-aef7-d977213ea034", "bf1533e7-d731-4083-8c41-e0cf8fcc8438", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "59e7ff7b-7957-4d8c-9580-5eb50d1c15d6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d6f2a354-538f-4e89-9d56-81e078c79afc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e05b5fb9-09fe-4a8b-aef7-d977213ea034");

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
    }
}
