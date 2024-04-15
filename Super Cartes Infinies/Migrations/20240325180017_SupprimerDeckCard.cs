using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class SupprimerDeckCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeckCard");

            migrationBuilder.AddColumn<int>(
                name: "DeckId",
                table: "OwnedCards",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f7cd735-89b2-4b4c-a8ae-34e5664ce3cd", "AQAAAAIAAYagAAAAEJX+g1bmJWSI6D8andzUwJZ5X6gK33RHDII2ZZXRqzdpdVLnf+5OSeMozmSbkxyvxA==", "a855a0f1-f028-43a5-bbae-5fed83d0de07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38ec78f5-6886-4d9b-ae3c-d1aa1c83be07", "f6f65832-12da-4e3a-bcf4-d2ecbac6c598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "620f72de-9343-4873-a607-9017d2f45614", "35a36ee6-cb8a-40ba-9b81-135b2cead20e" });

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCards_DeckId",
                table: "OwnedCards",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnedCards_Decks_DeckId",
                table: "OwnedCards",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "DeckId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnedCards_Decks_DeckId",
                table: "OwnedCards");

            migrationBuilder.DropIndex(
                name: "IX_OwnedCards_DeckId",
                table: "OwnedCards");

            migrationBuilder.DropColumn(
                name: "DeckId",
                table: "OwnedCards");

            migrationBuilder.CreateTable(
                name: "DeckCard",
                columns: table => new
                {
                    DeckCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    DeckId = table.Column<int>(type: "int", nullable: false),
                    OwnedCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckCard", x => x.DeckCardId);
                    table.ForeignKey(
                        name: "FK_DeckCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
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
                values: new object[] { "06251837-86bd-4e70-baa3-2b43bf28ce7d", "AQAAAAIAAYagAAAAEA0xvVsmHg5ORjzGeVXFmK7DZ9iA3IerhIcU+RbFQhRq7Y+Ab398EJfkSSSBsX0t/Q==", "6cc5c7be-1cea-4b2f-9b3b-f86c593d7257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd0f7e28-6466-4a2b-bf71-760add2d2a5f", "9f37b339-efc4-41e3-bb79-bc6de73a8c1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15c977e1-882d-4977-8897-1f1415604d0d", "a3fc39e8-bff8-4a2f-91d5-a97b72e66e72" });

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
