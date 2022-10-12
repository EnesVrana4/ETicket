using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class addimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "045bbd97-b7f5-4534-ab05-ecd2298358b7", "ca4d6673-b9b6-4c23-bd10-64ed8742a306", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8410612e-b5aa-40ac-86ae-16919e62ec22", "fd8f56db-4ddd-4325-b279-f8b205d96b77", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec4bb94e-556d-493e-9b24-7d64cc31627f", "1cf00a4f-5d3f-4286-93a3-7e81d73f441c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "045bbd97-b7f5-4534-ab05-ecd2298358b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8410612e-b5aa-40ac-86ae-16919e62ec22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec4bb94e-556d-493e-9b24-7d64cc31627f");

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
    }
}
