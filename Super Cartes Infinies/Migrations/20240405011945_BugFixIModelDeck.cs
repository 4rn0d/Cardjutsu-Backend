using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class BugFixIModelDeck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckOwnedCard_Decks_decksDeckId",
                table: "DeckOwnedCard");

            migrationBuilder.RenameColumn(
                name: "DeckId",
                table: "Decks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "decksDeckId",
                table: "DeckOwnedCard",
                newName: "decksId");

            migrationBuilder.RenameIndex(
                name: "IX_DeckOwnedCard_decksDeckId",
                table: "DeckOwnedCard",
                newName: "IX_DeckOwnedCard_decksId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3538f877-fff0-4824-aaa6-b652cc3152c2", "AQAAAAIAAYagAAAAEE5c7IbuUYeJ4/8z+d+fNm9jG3473sR62YLUhDnmvczMberRh8BCP1qms2x3gIL9dQ==", "ba608ae1-d733-44f5-8b81-7a23acf41a7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0a6872c-e037-483c-b28a-9140b7520e5f", "ded442fc-c800-4241-902e-6af68a13367b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a989c55a-4b8b-4eef-8ce1-88ec4aeb19aa", "ed737b35-c967-4465-a37f-8802a6309bf3" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckOwnedCard_Decks_decksId",
                table: "DeckOwnedCard",
                column: "decksId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckOwnedCard_Decks_decksId",
                table: "DeckOwnedCard");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Decks",
                newName: "DeckId");

            migrationBuilder.RenameColumn(
                name: "decksId",
                table: "DeckOwnedCard",
                newName: "decksDeckId");

            migrationBuilder.RenameIndex(
                name: "IX_DeckOwnedCard_decksId",
                table: "DeckOwnedCard",
                newName: "IX_DeckOwnedCard_decksDeckId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffe2af2e-304a-4602-b105-8958d324f20a", "AQAAAAIAAYagAAAAEHhXE7CGgyBzy9KhjlZq+dQZCXKQCYc86j4jqkulmXxWLPfqwNh9W9cSm8B1OkZG+g==", "43b3bb97-ca19-4961-b2a2-fb1d65eff566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "602fd9fe-f3d7-4bde-aad2-bcb351e2e6a9", "7b592246-d79d-40a7-b20d-220515d2b814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7435800f-b18c-455c-813e-8815988cb919", "8394472c-1c7f-4a03-867f-0cbafa3da8ad" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckOwnedCard_Decks_decksDeckId",
                table: "DeckOwnedCard",
                column: "decksDeckId",
                principalTable: "Decks",
                principalColumn: "DeckId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
