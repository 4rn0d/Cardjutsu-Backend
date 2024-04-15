using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCardFIXCardId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Cards_OwnedCardId",
                table: "DeckCard");

            migrationBuilder.RenameColumn(
                name: "OwnedCardId",
                table: "DeckCard",
                newName: "CardId");

            migrationBuilder.RenameIndex(
                name: "IX_DeckCard_OwnedCardId",
                table: "DeckCard",
                newName: "IX_DeckCard_CardId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56029aba-5bcc-4ced-8488-b593750cbb2b", "AQAAAAIAAYagAAAAEC56AChJlv1X+aiFSGMjvY5fsjHpmi447B/ZLrixXCGmbqeDcAAlrC2SThfYpt6i+Q==", "fbe679c4-9433-4bd9-8117-653cb554d689" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c247cc5d-741c-4c58-a3f8-0eb26c7a65e1", "2aa8c02e-9aa5-443a-b85c-568cd53b9541" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fdead57-f20f-430e-b27e-6c7205b06667", "3968446a-0db4-4c2d-8a89-ba31ab5d80d8" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Cards_CardId",
                table: "DeckCard",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Cards_CardId",
                table: "DeckCard");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "DeckCard",
                newName: "OwnedCardId");

            migrationBuilder.RenameIndex(
                name: "IX_DeckCard_CardId",
                table: "DeckCard",
                newName: "IX_DeckCard_OwnedCardId");

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
        }
    }
}
