using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class DeckOwnerCardLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeckCard");

            migrationBuilder.CreateTable(
                name: "DeckOwnedCard",
                columns: table => new
                {
                    OwnedCardsId = table.Column<int>(type: "int", nullable: false),
                    decksDeckId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckOwnedCard", x => new { x.OwnedCardsId, x.decksDeckId });
                    table.ForeignKey(
                        name: "FK_DeckOwnedCard_Decks_decksDeckId",
                        column: x => x.decksDeckId,
                        principalTable: "Decks",
                        principalColumn: "DeckId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeckOwnedCard_OwnedCards_OwnedCardsId",
                        column: x => x.OwnedCardsId,
                        principalTable: "OwnedCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83e060eb-02b9-42df-b83d-cfc28336eced", "AQAAAAIAAYagAAAAEBJJ3RPvUbVtFfq1tX3V1NbRK87rLLWtbWi7316WW8Yhjj+MtaJR0jNDjgNt0URaaQ==", "fb3e40f9-1174-4cdb-aa79-c4eed17d3e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b46d272-dd4f-4165-9078-cfceb61782d8", "0a411718-2ff3-42a1-8824-877f89187b79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "731cb459-1963-4442-8af3-176d9db80ae0", "d7e5d71f-f942-4dd2-88a2-cfbd9343294b" });

            migrationBuilder.CreateIndex(
                name: "IX_DeckOwnedCard_decksDeckId",
                table: "DeckOwnedCard",
                column: "decksDeckId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeckOwnedCard");

            migrationBuilder.CreateTable(
                name: "DeckCard",
                columns: table => new
                {
                    DeckCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    DeckId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckCard", x => x.DeckCardId);
                    table.ForeignKey(
                        name: "FK_DeckCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeckCard_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "DeckId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df3824c3-4c38-43e6-8eca-e2865a7becb0", "AQAAAAIAAYagAAAAEFOo64HM9Te/Nq16dxLv3O6a7QUvBOOI8QV+V4/ucuzLscH9IpDYeFAh4n+UE1ICMQ==", "432507ef-e6eb-49b1-8ae9-db7eaff11a4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b84903c-6e55-496b-9fb0-473754ee8049", "9420668d-3e3d-4e0f-aa3c-b17e6eb26505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1fe85fc5-63b7-41d8-a968-b4bd144bd71f", "b6fe421f-8160-4b07-8d76-1fd5e96a33c9" });

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_CardId",
                table: "DeckCard",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_DeckId",
                table: "DeckCard",
                column: "DeckId");
        }
    }
}
