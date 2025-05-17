using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Infrastrucure.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aad9035-641a-4801-a82a-89305bcab109");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a09c90-c7c6-4fe0-b1f7-39f2cea0a4ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ea0f3fb-1fad-4933-8f4f-fe63449ded16", null, "Admin", "ADMIN" },
                    { "4ee7d081-c558-4b63-887c-7c5c7a8482d0", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ea0f3fb-1fad-4933-8f4f-fe63449ded16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ee7d081-c558-4b63-887c-7c5c7a8482d0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6aad9035-641a-4801-a82a-89305bcab109", null, "Admin", "ADMIN" },
                    { "96a09c90-c7c6-4fe0-b1f7-39f2cea0a4ac", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
