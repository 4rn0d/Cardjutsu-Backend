using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCard3FIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Decks_Deckid",
                table: "DeckCard");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_OwnedCards_OwnedCardId",
                table: "DeckCard");

            migrationBuilder.RenameColumn(
                name: "Deckid",
                table: "DeckCard",
                newName: "DeckId");

            migrationBuilder.RenameIndex(
                name: "IX_DeckCard_Deckid",
                table: "DeckCard",
                newName: "IX_DeckCard_DeckId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c3ad6b1-bd1f-4a55-82d7-81091b40897b", "AQAAAAIAAYagAAAAEMcyRvTe4q5SGP5slmJRVOJhQshZG2yvrDeHDCYs2zT6txyin0NhjU1x7b87cciAZA==", "3dab7440-27ff-46c6-b270-70acdbe51aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ea69ae4-c037-42be-bee7-7958447019d1", "813ce454-09c9-456a-8b9a-7280af61bb09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93a16eb8-d57d-453c-bb4f-6ea3499e4e79", "19a6870f-e339-44d3-85d6-6fcf88ca185e" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Cards_OwnedCardId",
                table: "DeckCard",
                column: "OwnedCardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Decks_DeckId",
                table: "DeckCard",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "DeckId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Cards_OwnedCardId",
                table: "DeckCard");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Decks_DeckId",
                table: "DeckCard");

            migrationBuilder.RenameColumn(
                name: "DeckId",
                table: "DeckCard",
                newName: "Deckid");

            migrationBuilder.RenameIndex(
                name: "IX_DeckCard_DeckId",
                table: "DeckCard",
                newName: "IX_DeckCard_Deckid");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2914808-5b6c-4156-892f-3a6a20c6e36a", "AQAAAAIAAYagAAAAEI+qvZ8CYCyWZiwR3cpMiOrkPOukM3yLyxVRS8MiRiC08cmm15+zs5eeLepIFnCRuA==", "5602405e-5a4f-431d-898d-a042f55d8408" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16a7ab8c-7663-443d-b65e-14da9fde4456", "5c652131-c33a-4522-ae4d-21022751724c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "762ed292-4129-43f8-9ca5-8c440b46367a", "051918b4-090c-4e95-aaa4-95e344dcfa70" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Decks_Deckid",
                table: "DeckCard",
                column: "Deckid",
                principalTable: "Decks",
                principalColumn: "DeckId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_OwnedCards_OwnedCardId",
                table: "DeckCard",
                column: "OwnedCardId",
                principalTable: "OwnedCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
