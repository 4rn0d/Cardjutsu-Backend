using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AddMessageClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50a254b3-543e-4002-b839-bc0bdddb6764", "AQAAAAIAAYagAAAAEGPHU2KHHAuq9Gd+k7o4CeZJUf41lIfiv2b1DrZ6BaOVBMx+CI7/llIEd+2hD/lSOA==", "e162fb23-08a3-41c6-abbb-2fb6d34e45cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25badfcc-0296-4203-b562-300513a9feee", "c9546142-8323-479d-a898-87d33e408c58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a1743c9-fbb0-4209-9e25-9c1f05e9460d", "cfbccf0c-1491-47b4-9ba2-9ada6f4ae9cd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b1351b6-0a9b-450e-a4c0-fab16b68a916", "AQAAAAIAAYagAAAAEF6EDqmdTzPgWCPD2FiGbfXa3rdbHvHYLCuxO8iLyheP2vMrg98NmlUeKhPqCmwQnQ==", "2c6a20fd-912e-4f62-a86c-9b5cbf13dca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76c2d7aa-6b84-497c-ad74-3873d1b1350d", "a0a75ca3-de33-42b0-b7a0-fadda9ca9804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e11c8bd9-e1b4-46f3-9bc9-3c513415c99f", "f8e9c4c2-a9f4-4091-b222-a8d5162231d6" });
        }
    }
}
