using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class ajoutFkOwnedCard2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerID",
                table: "OwnedCards",
                newName: "PlayerId");

            migrationBuilder.RenameColumn(
                name: "CardID",
                table: "OwnedCards",
                newName: "CardId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bd7f31c-86a2-42c2-90c3-569771d30b3e", "AQAAAAIAAYagAAAAENfwrOjSMpcBZdUrw8SyI+jimNb7gz7BdUTVyp3AYiwTXV7aR+D7kk+bGIV1X7w9SQ==", "bd6e0b6f-4cf6-4515-b92d-f41bf1770842" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "OwnedCards",
                newName: "PlayerID");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "OwnedCards",
                newName: "CardID");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3bfc15-ea95-4d3b-b624-0e8b84e0a56c", "AQAAAAIAAYagAAAAEACho0POnukrDWA+Gl53JxmWwmjNnTAwAl/bEJLwqYW48sY9/UCx5CqFMwWB/qdgYw==", "7cef2f44-9c27-4129-a8a0-4041c728e526" });
        }
    }
}
