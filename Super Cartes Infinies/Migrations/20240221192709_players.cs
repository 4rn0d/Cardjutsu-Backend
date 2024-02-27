using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class players : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af123a56-32ab-42b6-8ca3-cffb661fc261", "AQAAAAIAAYagAAAAECSUOoedl44J1LuQElhUvH0r1p+Iyg61lkcFONKwR8YjalyDsSJY7QnUFn2E178twg==", "471ee43b-1e72-41c4-86f6-76cb96370068" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "User1Id", 0, "0755cedc-cf8b-4290-b30e-f905792efcab", null, false, false, null, null, null, null, null, false, "7a7eb5c4-2584-4ed9-914d-b2430c2bc497", false, null },
                    { "User2Id", 0, "c30b612f-2296-49db-8ac4-4baedf37a550", null, false, false, null, null, null, null, null, false, "9ee4e904-37eb-436a-b62c-f5c08c13104a", false, null }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "IdentityUserId", "Name" },
                values: new object[,]
                {
                    { 1, "User1Id", "Test player 1" },
                    { 2, "User2Id", "Test player 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdab8540-0309-41f5-b265-970765428f35", "AQAAAAIAAYagAAAAEDVvYsXrtC1IprDRB5MC3I978iZYucFfVAGFfjlAd4aM3BLoj9R3UzjyqrgL3O8GdA==", "a0bcbf3a-72e3-49fe-bb05-d02464ba1260" });
        }
    }
}
