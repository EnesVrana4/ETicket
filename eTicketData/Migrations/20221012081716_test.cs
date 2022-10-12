using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fcb38ff-7905-4796-b033-14e31c4bda15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7872c55e-720c-42ad-85f4-c677c6228ef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee6af8df-f7db-4ad3-8be3-5b788c66e536");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5123e5e4-b349-40d9-a2c7-1898978059c6", "2630a416-7e47-4b3b-b022-cf68dba867d6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5836b4e3-a45a-4fb6-af70-59d1e93da440", "410b2821-a174-4425-ad3c-9d84d8e84fa8", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7055d4ac-fe2f-4096-b2fc-20cfe3bb4fcf", "beb0e993-7810-4b74-b8f9-847a5120077c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5123e5e4-b349-40d9-a2c7-1898978059c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5836b4e3-a45a-4fb6-af70-59d1e93da440");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7055d4ac-fe2f-4096-b2fc-20cfe3bb4fcf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fcb38ff-7905-4796-b033-14e31c4bda15", "dd299c41-c091-46fd-a2e6-168af627443d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7872c55e-720c-42ad-85f4-c677c6228ef1", "0757c44a-7fac-4423-9fd8-03ed378e1134", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee6af8df-f7db-4ad3-8be3-5b788c66e536", "a32c701e-89ab-443f-9960-676aac2c8923", "Manager", "MANAGER" });
        }
    }
}
