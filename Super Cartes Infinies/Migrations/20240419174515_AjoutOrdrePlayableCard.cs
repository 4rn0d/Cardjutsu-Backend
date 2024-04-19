using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutOrdrePlayableCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrdreId",
                table: "PlayableCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrdreId",
                table: "PlayableCard");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b4ecec9-40d1-43f7-997f-d4091327a9b2", "AQAAAAIAAYagAAAAEP9NhOE2Z4tB1KM0zuSCS3bJbCK79452rHtsRUXjqm9w/Dvdn1UzajZ9rMNccuKm5Q==", "1dfd6e23-9630-401a-9703-db184ff91001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86354c74-b154-491f-a187-1c362aa3caf0", "7a668967-d646-44bb-b6f8-ed7751a5a20c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85b8c8aa-4108-4c1f-b7ca-a5ac3e365c36", "3e1aaab3-9e16-4d62-824d-1f9c3ffbdc97" });
        }
    }
}
