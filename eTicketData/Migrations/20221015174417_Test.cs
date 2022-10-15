using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketData.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8a9f6350-9af9-4fd7-88f1-c0cfeb1763d7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "95cccb04-026b-4691-aa1f-324d82ad8551");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ffcd38d2-cbbc-432e-a9c0-98163fb49b37");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d7e5231-b0fb-4019-bbbc-64d50c80272d", "b82e7bf1-4ab5-4a86-aba7-af42f3586515", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c069f1ce-04d7-4c23-8f13-100b62e8558c", "1694fa34-11f2-4215-b4c2-24047ffd3511", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fed5065d-b72c-4564-b359-1049a006d102", "ef73c569-0942-42d8-96fd-1d0de5a929ab", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7d7e5231-b0fb-4019-bbbc-64d50c80272d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c069f1ce-04d7-4c23-8f13-100b62e8558c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fed5065d-b72c-4564-b359-1049a006d102");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a9f6350-9af9-4fd7-88f1-c0cfeb1763d7", "89db96d4-d561-4299-b766-82175a7509a7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95cccb04-026b-4691-aa1f-324d82ad8551", "a26197df-8fd7-4e1c-96ab-61e975a558fb", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffcd38d2-cbbc-432e-a9c0-98163fb49b37", "c0a02980-8f89-4fe2-a13d-5e3baccc827b", "User", "USER" });
        }
    }
}
