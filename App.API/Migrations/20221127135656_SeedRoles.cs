using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10f177e4-c9f9-4214-95c4-dc3467b4d63b", "f31b594f-c2e2-4a8f-9d51-d15ab7125d0d", "User", "USER" },
                    { "e3067bb1-c25a-41b9-91d6-62f3d1d4f204", "26018b84-4262-440b-8bd5-8804b15ff4f4", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10f177e4-c9f9-4214-95c4-dc3467b4d63b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3067bb1-c25a-41b9-91d6-62f3d1d4f204");
        }
    }
}
