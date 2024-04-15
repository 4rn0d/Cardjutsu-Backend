using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class DeckCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    DeckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCurrentDeck = table.Column<bool>(type: "bit", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.DeckId);
                    table.ForeignKey(
                        name: "FK_Decks_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeckCard",
                columns: table => new
                {
                    DeckCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnedCardId = table.Column<int>(type: "int", nullable: false),
                    DeckId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckCard", x => x.DeckCardId);
                    table.ForeignKey(
                        name: "FK_DeckCard_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "DeckId");
                    table.ForeignKey(
                        name: "FK_DeckCard_OwnedCards_OwnedCardId",
                        column: x => x.OwnedCardId,
                        principalTable: "OwnedCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cd4421e-a581-426d-aea7-66e5562585df", "AQAAAAIAAYagAAAAEGAEzHicei5uLmKGCeJ0tAqw9C/Pmz+nrGdig9TlSVfAMOqTN29s6B2HhwaTLePBeQ==", "00b4464a-d2a6-433d-a10a-9f7cc23c150f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97ab4341-483f-49df-a4bf-c31ad0d4cbce", "d56250cc-cf97-43c4-bcd8-7427884d7b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12e0cb86-17d6-4d67-90e8-64adc61e6225", "0e694ebb-db94-4f22-88cb-cb3d57b908ca" });

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_DeckId",
                table: "DeckCard",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_OwnedCardId",
                table: "DeckCard",
                column: "OwnedCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_PlayerId",
                table: "Decks",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeckCard");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5915dad-3bad-40e4-beab-c1426eb5676f", "AQAAAAIAAYagAAAAEDm1IyMB6qz1eu46agQOCMehKrJV9Qcj+8OoiJBMe9MztOkb69KYWZP+8HAt6TYYRw==", "1f6e9cd6-a9d2-4aff-a840-20b452d60019" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5560bc06-1bde-4838-8be8-e6908b67b526", "623aafd6-af4f-40e1-906d-27464a4ab8a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a37ffc8a-3951-4803-864a-b8c3f892a0f2", "b5f6f6e9-ddd3-4cc8-a79d-de3c03cedb2b" });
        }
    }
}
